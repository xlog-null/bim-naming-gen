using System;
using System.Linq;

namespace bim_naming_generator
{
    internal class Generator
    {
        private Repository repo;

        public Generator(Repository repo)
        {
            this.repo = repo;
        }

        internal string GenerateNewNumber(string baseName)
        {
            var latestName = repo.GetLatestName(baseName);
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
            } while (repo.CheckIfExists(newName));
            return newNumber;
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

        interface IGeneratorListener
        {
            string OnGenerateResult();
            
        }
    }
}