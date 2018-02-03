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

        public string Name { get; set; }

        private PolicyCollection ownedPolicies;

        //Methods

        public void ViewPolicies(string type)
        {
            ownedPolicies.DisplayPolicy(type);
        }

        public Policy FindPolicy(string id)
        {
            return ownedPolicies.SearchPolicy(id);
        }

        public abstract float CalculateCommission();

    }
}
