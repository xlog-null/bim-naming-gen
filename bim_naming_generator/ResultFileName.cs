using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bim_naming_generator
{
    internal class ResultFileName
    {
        private Field projectCode = new Field("", 2, 6);
        private Field originator = new Field("", 3, 6);
        private Field volOrSystem = new Field("", 1, 2);
        private Field levels = new Field("", 2, 2);
        private Field type = new Field("", 2, 2);
        private Field role = new Field("", 1, 2);
        private Field number = new Field("", 2, 6);

        private List<Field> allFields = new List<Field>();

        public ResultFileName()
        {
            allFields.Add(projectCode);
            allFields.Add(originator);
            allFields.Add(volOrSystem);
            allFields.Add(levels);
            allFields.Add(type);
            allFields.Add(role);
            allFields.Add(number);
        }
        /**
         * Returns a string to be displayed on the form regardless
         * of whether all fields are filled in. If a field is not
         * filled in, display special symbols in its place instead.
         */ 
        public String Display()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Field field in allFields)             {
                sb.Append(field.getDisplayString());
                if (field != allFields.Last()) {
                    sb.Append("-");
                }
            }
            return sb.ToString();
        }
    }



   
}
