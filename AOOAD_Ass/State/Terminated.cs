using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass.State
{
    class Terminated : PolicyState
    {
        private Policy policy;
        public Terminated(Policy policy)
        {
            this.policy = policy;
        }
        public void ActivatePolicy()
        {
            Console.WriteLine("Terminated policy cannot be active again");
        }

        public void ArchivePolicy()
        {
            Console.WriteLine("Policy is now archived!");
        }

        public void LapsePolicy()
        {
            Console.WriteLine("Terminated policy cannot be lapsed again");
        }

        public void TerminatePolicy()
        {
            Console.WriteLine("Policy is already terminated..");
        }

        public void TerminatePolicy(bool penalty)
        {
            Console.WriteLine("Policy is already terminated..");
        }
    }
}
