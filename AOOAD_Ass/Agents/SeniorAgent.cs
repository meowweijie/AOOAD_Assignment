﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Ass.Agents
{
    class SeniorAgent : Agent
    {
        public SeniorAgent() : base()
        {

        }

        public SeniorAgent(string name, float commission) : base(name, commission)
        {

        }
        public override float CalculateCommission()
        {
            float commission = 0;
            // implementation
            return commission;
        }
    }
}
