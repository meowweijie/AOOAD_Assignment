using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;


namespace AOOAD_Ass.Iterator
{
    interface Iterator
    {
        Boolean HasNext();
        Policy Next();
        
    }
}
