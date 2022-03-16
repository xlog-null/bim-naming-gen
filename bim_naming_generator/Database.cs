using System.Collections;

namespace bim_naming_generator
{
    internal class Database
    {

        // mock data
        private ArrayList data = new ArrayList();
        
        public Database()
        {
            data.Add("a-a-a-a-a-a-a-001");
            data.Add("a-a-a-a-a-a-a-002");
            data.Add("a-a-a-a-a-a-a-003");
            data.Add("a-a-a-a-a-a-a-004");
            data.Add("a-a-a-a-a-a-a-005");
        }

        public ArrayList GetAllFileNames()
        {
            return data;
        }
    }
}