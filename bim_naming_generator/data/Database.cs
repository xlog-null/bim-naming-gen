using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static bim_naming_generator.Repository;

namespace bim_naming_generator
{
    internal class Database
    {
        private string cs = @"Server= exyte-sql; Database= BIM_Name_Gen; Integrated Security=True;";
        private string csSage = @"Server= exyte-sql\sage; Database= harglive; Integrated Security=True;";
        private IRepositoryListener listener;
        private string fieldTablePrefix = "field_";

        public Database(IRepositoryListener listener)
        {
            this.listener = listener;
        }

        internal void FetchProjects()
        {
            var projects = new List<string>();
            using (var dbConn = new SqlConnection(csSage))
            {
                dbConn.Open();
                var commandText = "SELECT contract_code, description FROM HDL_ContractDescriptions";
                var command = new SqlCommand(commandText, dbConn);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        throw new System.Exception("Fetching project list returned 0 rows.");
                    }

                    while (reader.Read())
                    {
                        var code = reader.GetString(0).Trim(' ');
                        code = "E" + code;
                        var name = reader.GetString(1).Trim(' ');
                        projects.Add(code + " - " + name);
                    }
                }
            }
            listener.OnFetchProjectsSuccess(projects);
        }

        internal void FetchClaimHistory(string userName)
        {
            var filenames = new List<string>();
            var dates = new List<string>();
            using (var dbConn = new SqlConnection(cs))
            {
                dbConn.Open();
                var commandText =
                    "SELECT name, date_created FROM filename " +
                    "WHERE created_by=@userName";
                var command = new SqlCommand(commandText, dbConn);
                command.Parameters.AddWithValue("@userName", userName);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        filenames.Add(reader.GetString(0));
                        dates.Add(reader.GetDateTime(1).ToString());
                    }
                }
            }
            listener.OnFetchClaimHistorySuccess(filenames, dates);
        }

        internal void FetchFieldOptions(string project)
        {
            var tableName = fieldTablePrefix + project;
            var fieldOptions = new List<FieldOption>();
            using (var dbConn = new SqlConnection(cs))
            {
                dbConn.Open();
                // Cannot use table as an SQLParameter! So have to concatenate the query.
                // Using string concatenation but the input will be only from pre-defined options for user,
                // so this is safe from SQL Injection.
                var commandText = "SELECT type, value, description FROM " + tableName;
                var command = new SqlCommand(commandText, dbConn);

                using (var reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        throw new System.Exception("Fetching field options returned 0 rows.");
                    }

                    while (reader.Read())
                    {
                        var type = reader.GetString(0);
                        var value = reader.GetString(1);
                        var description = reader.GetString(2);
                        var fieldOption = new FieldOption(type, value, description);
                        fieldOptions.Add(fieldOption);
                    }
                }
            }
            listener.OnFetchFieldOptionsSuccess(fieldOptions, project);
        }

        internal void ClaimFileName(string filename)
        {
            string errorMessage = "";
            bool success = false;
            bool exists = CheckIfExists(filename);
            if (exists)
            {
                errorMessage = "File name already exists in database.";
                success = false;
            }
            else
            {
                //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string userName = System.Environment.UserName;
                DateTime myDateTime = DateTime.Now;
                string dateTime = myDateTime.ToString("dd/MM/yyyy HH:mm:ss");
                var commandText = "INSERT INTO filename (name, created_by, date_created) VALUES (@filename, @user, @dateTime)";
                using (var dbConn = new SqlConnection(cs))
                {
                    dbConn.Open();
                    var command = new SqlCommand(commandText, dbConn);
                    command.Parameters.AddWithValue("@filename", filename);
                    command.Parameters.AddWithValue("@user", userName);
                    command.Parameters.AddWithValue("@dateTime", dateTime);
                    command.CommandTimeout = 3;
                    if (command.ExecuteNonQuery().Equals(1))
                    {
                        listener.OnFileClaimSuccess(filename, dateTime);
                    }
                    else
                    {
                        throw new System.Exception("Adding file name to database failed.");
                    }
                }
            }
        }

        public bool CheckIfExists(string filename)
        {
            using (var dbConn = new SqlConnection(cs))
            {
                dbConn.Open();
                var commandText = "SELECT Id FROM filename WHERE name=@filename";
                var command = new SqlCommand(commandText, dbConn);
                command.Parameters.AddWithValue("@filename", filename);
                var dataReader = command.ExecuteReader();
                return dataReader.HasRows;
            }
        }

        public string GetLatestName(string baseName)
        {
            var query = "SELECT TOP 1 name " +
                "FROM filename " +
                "WHERE name LIKE @baseName " +
                "ORDER BY name DESC";
            string result = "";
            using (var dbConn = new SqlConnection(cs))
            {
                dbConn.Open();
                var command = new SqlCommand(query, dbConn);
                command.Parameters.AddWithValue("@baseName", baseName + "%");
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        result = reader.GetString(0);
                    }
                    else
                    {
                        result = "";
                    }
                }
                
            }
            return result;
        }
    }
}