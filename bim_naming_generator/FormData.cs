using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bim_naming_generator
{
    internal class FormData
    {
        public Dictionary<string, Field> fields = new Dictionary<string, Field>()
       {
           {"projectCode", new Field("", 2, 6) },
            {"originator", new Field("", 3, 6) },
            {"volOrSystem", new Field("", 1, 2) },
            {"levelsAndLocations", new Field("", 2, 2) },
            {"type", new Field("", 2, 2) },
            {"role", new Field("", 1, 2) },
            {"number", new Field("", 2, 6) }
       };

        //public Field projectCode = new Field("", 2, 6);
        //public Field originator = new Field("", 3, 6);
        //public Field volOrSystem = new Field("", 1, 2);
        //public Field levels = new Field("", 2, 2);
        //public Field type = new Field("", 2, 2);
        //public Field role = new Field("", 1, 2);
        //public Field number = new Field("", 2, 6);

        //private List<Field> allFields = new List<Field>();

        public FormData()
        {
            //allFields.Add(projectCode);
            //allFields.Add(originator);
            //allFields.Add(volOrSystem);
            //allFields.Add(levels);
            //allFields.Add(type);
            //allFields.Add(role);
            //allFields.Add(number);
        }
        /**
         * Returns a string to be regardless of whether all fields are filled in.
         * If a field is not filled in, display special symbols in its place instead.
         */ 
        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in fields)             {
                sb.Append(item.Value.GetDisplayString());
                if (!item.Equals(fields.Last()) && item.Value.content.Length > 0) {
                    sb.Append("-");
                }
            }
            return sb.ToString();
        }
    }



   
}
