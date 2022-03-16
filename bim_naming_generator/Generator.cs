namespace bim_naming_generator
{
    internal class Generator
    {
        private Repository repository = new Repository();

        public string GenerateFileName(string baseName)
        {
            string number = "000001";
            var data = repository.GetFiles(baseName);
            if (data.Count == 0)
            {
                return baseName + "-" + number;
            }

            return "";
        } 
    }
}