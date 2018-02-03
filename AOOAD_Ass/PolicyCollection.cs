﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;
using AOOAD_Ass.Iterator;

namespace AOOAD_Ass
{
    class PolicyCollection
    {
        //Attributes
        private List<Policy> ownedPolicies = new List<Policy>();

        //Methods
        public void AddPolicy()
        {

        }

        public PolicyIterator CreateIterator(string type)
        {
            if(type=="Existing")
            {
                ExistingPolicyIterator iter = new ExistingPolicyIterator(ownedPolicies);
                return iter;
            }
            else if(type=="Matured")
            {
                MaturedPolicyIterator iter = new MaturedPolicyIterator(ownedPolicies);
                return iter;
            }
            else if(type=="Terminated")
            {
                TerminatedPolicyIterator iter = new TerminatedPolicyIterator(ownedPolicies);
                return iter;
            }
            else
            {
                return null;
            }
        }

        public void displayPolicy(string type)
        {
            PolicyIterator iter = CreateIterator(type);
            Policy policy;
            while(iter.HasNext())
            {
                policy = iter.Next();
            }
        }
    }
}
