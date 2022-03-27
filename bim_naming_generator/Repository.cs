using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace bim_naming_generator
{

    // TODO: MAKE CACHABLE INSTEAD OF NETWORK RETRIEVE.
    internal class Repository
    {
        private string dataDir = @"\\exyte-file01\programs\BIM Naming Generator\data\field_values\";
        private string projectValuesDir = @"General\";
        private List<string> specialProjectCases;
        private string projectCodesFile;

        public Repository()
        {
            projectCodesFile = dataDir + "project_codes.txt";
            specialProjectCases = new List<string>();
            specialProjectCases.Add("E21356 – HPC");
        }

        // Sets projectValuesDir to directory based on the project parameter.
        // Returns True if the new directory is different than before.
        public bool SetProjectCode(string project)
        {
            var oldProjectValuesDir = projectValuesDir;
            if (specialProjectCases.Contains(project))
            {
                projectValuesDir = project + @"\";
            }
            else
            {
                projectValuesDir = @"General\";
            }
            return !oldProjectValuesDir.Equals(projectValuesDir);
        }

        public string[] LoadProjectCodes()
        {
            return System.IO.File.ReadAllLines(projectCodesFile);
        }

        // todo: make cachable.
        public string[] LoadData(string filename)
        {
            var path = dataDir + projectValuesDir + filename;
            return System.IO.File.ReadAllLines(path);
        }

        internal bool IsProjectSpecialCase(string project)
        {
            return specialProjectCases.Contains(project);
        }
    }
}