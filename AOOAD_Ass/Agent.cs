using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Ass
{
    abstract class Agent
    {
        private string agentId;

        public string AgentId
        {
            get { return agentId; }
            set { agentId = value; }
        }

        private float commission;

        public float Commission
        {
            get { return commission; }
            set { commission = value; }
        }
        public abstract float calculateCommission();

    }
}
