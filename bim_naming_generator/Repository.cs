using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace bim_naming_generator
{
    internal class Repository
    {
        private string fieldValuesDir = @"\\exyte-file01\programs\BIM Naming Generator\data\field_values\";

        public string[] LoadData(string filename)
        {
            var path = fieldValuesDir + filename;
            return System.IO.File.ReadAllLines(path);
        }
    }
}