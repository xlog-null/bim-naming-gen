using System;
using System.Linq;

namespace bim_naming_generator
{
    internal class Generator
    {
        private Database db = new Database();

        internal string GenerateNewNumber(string baseName)
        {
            var latestName = db.GetLatestName(baseName);
            var newNumber = "000001";
            if (latestName == "")
            {
                return newNumber;
            }
            string newName;
            do
            {
                newNumber = GetNextNumber(latestName);
                newName = baseName + newNumber;
            } while (db.CheckIfExists(newName));
            return newNumber;
        }


        private string GetNextNumber(string name)
        {
            var number = GetNumberFromFilename(name);
            int newNumber = int.Parse(number) + 1;
            return newNumber.ToString();
        }

        private string GetNumberFromFilename(string fileName)
        {
            return fileName.Split('-').Last();
        }
    }
}