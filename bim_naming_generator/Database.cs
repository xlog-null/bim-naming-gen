using System;
using System.Collections;
using System.Data.SQLite;

namespace bim_naming_generator
{
    internal class Database
    {
        private string connectionString = @"URI=file:\\exyte-file01\programs\BIM Naming Generator\data\filenames.db";
        private DbListener listener;

        public Database(DbListener listener)
        {
            this.listener = listener; 
        }

        internal void ClaimFileName(string fileName)
        {
            string errorMessage = "";
            bool success = false;
            bool exists = CheckIfExists(fileName);
            if (exists)
            {
                errorMessage = "File name already exists in database.";
                success = false;
            } else
            {
                using (var dbConn = new SQLiteConnection(connectionString, true))
                {
                    dbConn.Open();
                    using (var command = new SQLiteCommand(dbConn))
                    {
                        command.CommandText = "INSERT INTO filenames (filename) VALUES (@filename)";
                        command.Parameters.AddWithValue("@filename", fileName);
                        command.CommandTimeout = 3;
                        if (command.ExecuteNonQuery().Equals(1))
                        {
                            success = true;
                        }
                        else
                        {
                            errorMessage = "Adding file name to database failed.";
                            success = false;
                        }
                    }

                }
            }
            listener.OnFileClaimResult(fileName, success, errorMessage);
        }

        public bool CheckIfExists(string fileName)
        {
            using (var dbConn = new SQLiteConnection(connectionString, true))
            {
                dbConn.Open();
                using (var command = new SQLiteCommand(dbConn))
                {
                    command.CommandText = "SELECT Id FROM filenames WHERE filename=@fileName";
                    command.Parameters.AddWithValue("@filename", fileName);

                    var dataReader = command.ExecuteReader();
                    return dataReader.HasRows;
                }
            }
        }

        public string GetLatestName(string baseName)
        {
            var query = "SELECT filename " +
                "FROM filenames " +
                "WHERE filename LIKE @baseName " +
                "ORDER BY filename DESC " +
                "LIMIT 1";
            string result = "";
            using (var dbConn = new SQLiteConnection(connectionString, true))
            {
                dbConn.Open();
                using (var command = new SQLiteCommand(dbConn))
                {
                    command.CommandText = query;
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
            }
            return result;
        }
    }
}