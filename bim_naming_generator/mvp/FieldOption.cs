using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bim_naming_generator
{
    /**
     * Used for storing project field options, to be used for MainForm field ComboBox selection option list.
     **/
    public class FieldOption
    {
        public string type;
        public string value;
        public string description;

        public FieldOption(string type, string value, string description)
        {
            this.type = type;
            this.value = value;
            this.description = description;
        }

        public override string ToString()
        {
            return value + " - " + description;
        }
    }
}
