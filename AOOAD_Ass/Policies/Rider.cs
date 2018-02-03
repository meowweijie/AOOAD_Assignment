using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Ass.Policies
{
    class Rider
    {
        public int riderNo { get; set; }
        public string riderType { get; set; }
        public float amount { get; set; }
        public Rider() { }
        public Rider(int no, string type, float a)
        {
            riderNo = no;
            riderType = type;
            amount = a;
        }
    }
}
