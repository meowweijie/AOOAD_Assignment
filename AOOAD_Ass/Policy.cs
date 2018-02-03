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
        public bool payOut { get; set; }
        public bool periodic { get; set; }
        public float premium { get; set; }

        void Lapse()
        {

        }

        void Activate()
        {

        }

        void Terminate(bool penalty)
        {

        }

        void Archive()
        {

        }

        float calculatePayout()
        {
            float x = 5; //temp cause error is annoying
            return x;
        }

        void addRider(Rider rider)
        {

        }

        void generateAlert()
        {

        }
    }
}
