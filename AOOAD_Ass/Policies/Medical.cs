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
        public Medical(string polNo, string terms, DateTime duedate, DateTime maturitydate, List<Rider> riderlist, bool payout, bool periodic, float premium, string s):base(string polNo, string terms, DateTime duedate, DateTime maturitydate, List < Rider > riderlist, bool payout, bool periodic, float premium)
        {
            severity = s;
        }

        public string severity { get; set; }
        public override float CalculatePayout()
        {
            float x = 0;
            //implementation
            return x;
        }
    }
}
