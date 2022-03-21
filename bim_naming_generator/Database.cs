using System;
using System.Collections;
using System.Data.SqlClient;

namespace bim_naming_generator
{
    internal class Database
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\dev\bim-naming-gen\bim_naming_generator\database.mdf;Integrated Security = True";
        private SqlConnection dbConn;


        // mock data
        private ArrayList data = new ArrayList();
        
        public Database()
        {
            dbConn = new SqlConnection(connectionString);
        }

        public bool CheckIfExists(string filename)
        {
            var query = "SELECT Id FROM filenames WHERE filename=" + filename;
            dbConn.Open();
            var command = new SqlCommand(query, dbConn);
            var dataReader = command.ExecuteReader();
            var exists = dataReader.HasRows;
            dbConn.Close();
            return exists;
        }

        public string GetLatestName(string baseName)
        {
            var query = "SELECT TOP 1 filename " +
                "FROM filenames " +
                "WHERE filename LIKE '%" + baseName + "%' " +
                "ORDER BY filename DESC";
            dbConn.Open();
            var reader = new SqlCommand(query, dbConn).ExecuteReader();
            string result = "";
            if(reader.HasRows) 
            {
                reader.Read();
                result = reader.GetString(0);
            } else
            {
                result = "";
            }
            dbConn.Close();
            return result;
        }

        public ArrayList GetAllFileNames()
        {
            return data;
        }
    }
}