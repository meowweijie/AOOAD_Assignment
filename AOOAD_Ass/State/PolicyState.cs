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
        void LapsePolicy();
        void ActivatePolicy();
        void TerminatePolicy();
        void TerminatePolicy(bool penalty);
        void ArchivePolicy();
    }
}
