﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Ass.Policies
{
    class Travel:Policy
    {
        public Travel() { }
        public Travel(Policy p)
        {

        }
        public override float CalculatePayout()
        {
            return 0;
        }
    }
}
