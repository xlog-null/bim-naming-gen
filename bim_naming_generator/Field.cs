using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bim_naming_generator
{
    internal class Field
    {
        protected String content;
        private int minChars, maxChars;

        public Field(String content, int minChars, int maxChars)
        {
            this.content = content;
            this.minChars = minChars;
            this.maxChars = maxChars;
        }

        public Boolean IsValid()
        {
            return content.Length >= minChars || content.Length <= maxChars;
        }

        public String getDisplayString()
        {
            if (IsValid())
            {
                return content;
            } else
            {
                return "?";
            }
        }
    }
}
