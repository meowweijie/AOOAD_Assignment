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
            Console.WriteLine("Policy is Lapsed.");
        }

        public void terminatePolicy()
        {
            if(policy.PayOut==true || DateTime.Now > policy.MaturityDate)
            {
                Console.WriteLine("Policy paid out/matured. Policy is terminated.");
                policy.setState(policy.getTerminatedState());
            }
            else { Console.WriteLine("Unable to terminate policy."); }
        }

        public void terminatePolicy(bool penalty)
        {
            Console.WriteLine("Unable to terminate policy.");
        }
    }
}
