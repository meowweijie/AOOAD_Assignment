using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass.State
{
    class Active : PolicyState
    {
        private Policy policy;

        public Active(Policy policy)
        {
            this.policy = policy;
        }
        public void activatePolicy()
        {
            Console.WriteLine("Policy is already in active state!");
        }

        public void archivePolicy()
        {
            Console.WriteLine("Unable to archive policy from active state");
        }

        public void lapsePolicy()
        {
            policy.setState(policy.getLapsedState());
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
