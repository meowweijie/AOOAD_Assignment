using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Iterator;

namespace AOOAD_Ass
{
    class Client
    {
        private string clientNo;

        public string ClientNo
        {
            get { return clientNo; }
            set { clientNo = value; }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNo { get; set; }

        private PolicyCollection ownedPolicy;



        //Operations
        public void Pay(float amount)
        {
            //Implementation
        }

        public void ViewPolicy()
        {
            
        }


    }
}
