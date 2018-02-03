using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Ass.Policies
{
    class Medical:Policy
    {
        public Medical() { }
        public Medical(Policy p, string s)
        {
            severity = s;
        }

        public string severity { get; set; }
        public override float CalculatePayout()
        {
            return 0;
        }
    }
}
