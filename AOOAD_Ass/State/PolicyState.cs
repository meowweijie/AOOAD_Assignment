using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass.State
{
    public interface PolicyState
    {
        void lapsePolicy();
        void activatePolicy();
        void terminatePolicy();
        void terminatePolicy(bool penalty);
        void archivePolicy();
    }
}
