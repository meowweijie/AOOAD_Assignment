using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass.Agents
{
    abstract class Agent
    {
        //Attributes
        private string agentNo;

        public string AgentNo
        {
            get { return agentNo; }
            set { agentNo = value; }
        }

        private float commission;

        public float Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        private PolicyCollection ownedPolicies = new PolicyCollection();
        //Methods
        public abstract float CalculateCommission();
        public void addPolicy(Policy p)
        {
            ownedPolicies.AddPolicy(p);
        }
        public void editPolicy(Policy policy)           //edit policy
        {
            if(policy is Car)
            {
                Console.WriteLine("Car");
            }
            else if(policy is Medical)
            {
                Console.WriteLine("Medical");
            }
            else if (policy is Travel)
            {
                Console.WriteLine("Travel");
            }
            Console.WriteLine("editPolicy end");
        }
    }
}
