using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass.Iterator
{
    class TerminatedPolicyIterator:PolicyIterator
    {
        List<Policy> policies;
        int pos = 0;

        public TerminatedPolicyIterator(List<Policy> p)
        {
            this.policies = p;


            while ((pos < policies.Count) && !policies[pos].IsTerminated())
            {
                ++pos;
            }
        }

        public bool HasNext()
        {
            if (pos < policies.Count)
                return true;
            else
                return false;
        }

        public Policy Next()
        {
            Policy p = policies[pos];
            ++pos;

            while ((pos < policies.Count) && !policies[pos].IsTerminated())
            {
                ++pos;
            }

            return p;
        }
    }
}
