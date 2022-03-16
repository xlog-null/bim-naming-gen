using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace bim_naming_generator
{
    internal class Repository
    {

        private Database db = new Database();
        private string fieldValuesDir = "F:\\dev\\bim-naming-gen\\bim_naming_generator\\field_values\\";

        public ArrayList GetFiles(string baseName)
        {
            var allFileNames = db.GetAllFileNames();
            var filtered = new ArrayList();
            foreach (string file in allFileNames)
            {
                if (file.Contains(baseName))
                {
                    filtered.Add(file);
                }
            }
            return filtered;
        }

        public bool IsFileNameTaken(string fileName)
        {
            Thread.Sleep(2);
            return db.GetAllFileNames().Contains(fileName);
        }

        public string[] LoadData(string filename)
        {
            var path = fieldValuesDir + filename; 
            return System.IO.File.ReadAllLines(path);
        }
    }
}
