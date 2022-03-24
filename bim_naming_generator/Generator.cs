using System;
using System.Linq;

namespace bim_naming_generator
{
    internal class Generator
    {
        private Database db;
        private GeneratorListener listener;

        public Generator(Database db, GeneratorListener listener)
        {
            this.db = db;
            this.listener = listener;
        }


        internal void GenerateNewNumber(string baseName)
        {
            var latestName = db.GetLatestName(baseName);
            var newNumber = "000001";
            if (latestName == "")
            {
                listener.OnGenerateResult(newNumber, true);
                return;
            }
            string newName;
            do
            {
                newNumber = GetNextNumber(latestName);
                newName = baseName + newNumber;
            } while (db.CheckIfExists(newName));
            listener.OnGenerateResult(newNumber, true);
        }


        private string GetNextNumber(string name)
        {
            var number = GetNumberFromFilename(name);
            int newNumber = int.Parse(number) + 1;
            return newNumber.ToString().PadLeft(6, '0');
        }

        private string GetNumberFromFilename(string fileName)
        {
            return fileName.Split('-').Last();
        }
    }
}