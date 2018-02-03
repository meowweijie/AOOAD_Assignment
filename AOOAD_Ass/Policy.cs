using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Ass
{
    class Policy
    {
        public string policyNo { get; set; }
        public string termsCondition { get; set; }
        public DateTime maturityDate { get; set; }
        public List<Rider> ridersList { get; set; }
        public float payOut { get; set; }
    }
}
