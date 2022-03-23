using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bim_naming_generator
{
    internal interface DbListener
    {
        void OnFileClaimResult(string fileName, bool success, string errorMessage);
    }
}
