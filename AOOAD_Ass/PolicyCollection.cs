using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass
{
    class PolicyCollection
    {
        //Attributes
        private List<Policy> ownedPolicies = new List<Policy>();

        //Methods
        public void AddPolicy(Policy p)
        {
            ownedPolicies.Add(p);
        }
        public void cancelPolicy(Policy p)
        {
            ownedPolicies.Remove(p);
        }

        public void CreateIterator()
        {

        }
    }
}
