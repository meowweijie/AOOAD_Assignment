using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Ass.Policies
{
    class Car:Policy
    {
        public Car() { }
        public Car(string terms, DateTime duedate, DateTime maturitydate, List<Rider> riderlist, bool payout, bool periodic, float premium) : base(terms, duedate, maturitydate, riderlist, payout, periodic, premium)
        {
            
        }

        public override float CalculatePayout()
        {
            float x = 0;
            //implementation
            return x;
        }
    }
}
