﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Ass.Agents
{
    class NormalAgent : Agent
    {

        public NormalAgent() : base()
        {

        }

        public NormalAgent(string name, float commission) : base(name, commission)
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
