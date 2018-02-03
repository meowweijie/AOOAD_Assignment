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
        public void activatePolicy()
        {
            policy.setState(policy.getActiveState());
            Console.WriteLine("Successfully changed from lapsed to active state!");
        }

        public void archivePolicy()
        {
            Console.WriteLine("Cannot archive a lapsed policy!");
        }

        public void lapsePolicy()
        {
            Console.WriteLine("Cannot change back to the same state.");
        }

        public void terminatePolicy()
        {
            Console.WriteLine("Unable to terminate policy.");
        }

        public void terminatePolicy(bool penalty)
        {
            if (penalty)
                Console.WriteLine("Customer terminated this, a penalty fee must be charged");
            else
                Console.WriteLine("Agent terminated this, no penalty is charged");
            policy.setState(policy.getTerminatedState());
        }
    }
}
