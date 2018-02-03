using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass.State
{
    interface PolicyState
    {
        void lapsePolicy();
        void activatePolicy();
        void terminatePolicy(bool penalty);
        void archivePolicy();
    }
}
