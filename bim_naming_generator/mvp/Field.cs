using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bim_naming_generator
{

    /**
     * Used by MainForm for field validation and storing user input.
     * Not for storing project field options.
     **/
    internal class Field
    {
        public string content;
        private int minChars, maxChars;

        public Field(String content, int minChars, int maxChars)
        {
            this.content = content;
            this.minChars = minChars;
            this.maxChars = maxChars;
        }

        public void SetContent(String content)
        {
            this.content = content.Split(' ').First().ToUpper();
        }

        public Boolean IsValid()
        {
            return content.Length >= minChars && content.Length <= maxChars;
        }

        public String GetDisplayString()
        {
            return content;
        }
    }
}
