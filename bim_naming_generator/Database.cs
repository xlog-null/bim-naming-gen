using System;
using System.Collections;
using System.Data.SqlClient;

namespace bim_naming_generator
{
    internal class Database
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\dev\bim-naming-gen\bim_naming_generator\database.mdf;Integrated Security = True";
        //private SqlConnection dbConn;

        private DbListener listener;


        // mock data
        private ArrayList data = new ArrayList();

        public Database(DbListener listener)
        {

            this.listener = listener;
            //dbConn = new SqlConnection(connectionString);
            
        }

        internal void Close()
        {
            //if (dbConn != null && dbConn.State == System.Data.ConnectionState.Open)
            //{
            //    dbConn.Close();
            //}
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
                var query = "INSERT INTO filenames (filename) VALUES ('" + fileName + "')";

                using (var dbConn = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(query, dbConn);
                    dbConn.Open();
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
            listener.OnFileClaimResult(fileName, success, errorMessage);
        }

        public bool CheckIfExists(string filename)
        {
            var query = "SELECT Id FROM filenames WHERE filename='" + filename + "'";
            using (var dbConn = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, dbConn);
                dbConn.Open();
                var dataReader = command.ExecuteReader();
                var exists = dataReader.HasRows;
                dbConn.Close();
                return exists;
            }
        }

        public string GetLatestName(string baseName)
        {
            var query = "SELECT TOP 1 filename " +
                "FROM filenames " +
                "WHERE filename LIKE '%" + baseName + "%' " +
                "ORDER BY filename DESC";
            using (var dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                var reader = new SqlCommand(query, dbConn).ExecuteReader();
                string result = "";
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetString(0);
                }
                else
                {
                    result = "";
                }
                dbConn.Close();
                return result;
            }
        }

        public ArrayList GetAllFileNames()
        {
            return data;
        }
    }
}