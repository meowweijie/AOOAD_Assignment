using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass.State
{
    class Lapsed : PolicyState
    {
        private Policy policy;

        public Lapsed(Policy policy)
        {
            this.policy = policy;
        }
        public void ActivatePolicy()
        {
            policy.SetState(policy.GetActiveState());
            Console.WriteLine("Successfully changed from lapsed to active state!");
        }

        public void ArchivePolicy()
        {
            Console.WriteLine("Cannot archive a lapsed policy!");
        }

        public void LapsePolicy()
        {
            Console.WriteLine("Cannot change back to the same state.");
        }

        public void TerminatePolicy()
        {
            Console.WriteLine("Unable to terminate policy.");
        }

        public void TerminatePolicy(bool penalty)
        {
            if (penalty)
                Console.WriteLine("Customer terminated this, a penalty fee must be charged");
            else
                Console.WriteLine("Agent terminated this, no penalty is charged");
            policy.SetState(policy.GetTerminatedState());
        }
    }
}
