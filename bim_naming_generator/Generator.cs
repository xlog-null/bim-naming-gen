using System;
using System.Linq;

namespace bim_naming_generator
{
    internal class Generator
    {
        private Database db = new Database();
        private GeneratorListener listener;

        public Generator(GeneratorListener listener)
        {
            this.listener = listener;
        }


        internal void GenerateNewNumber(string baseName)
        {
            var latestName = db.GetLatestName(baseName);
            var newNumber = "000001";
            if (latestName == "")
            {
                listener.OnGeneratedSuccess(newNumber);
                return;
            }
            string newName;
            do
            {
                newNumber = GetNextNumber(latestName);
                newName = baseName + newNumber;
            } while (db.CheckIfExists(newName));
            listener.OnGeneratedSuccess(newNumber);
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