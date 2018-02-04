using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass.Agents
{
    abstract class Agent
    {
        //Attributes
        private string agentNo;

        public string AgentNo
        {
            get { return agentNo; }
            set { agentNo = value; }
        }

        private float commission;

        public float Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        private PolicyCollection ownedPolicies = new PolicyCollection();


        //Methods
        public void ViewPolicies(string type)
        {
            ownedPolicies.DisplayPolicy(type);
        }

        public Policy FindPolicy(string id)
        {
            return ownedPolicies.SearchPolicy(id);
        }

        public abstract float CalculateCommission();
        public void addPolicy(Policy p)
        {
            ownedPolicies.AddPolicy(p);
        }
        public void editPolicy(Policy policy)           //edit policy
        {
            Console.WriteLine("1. Add Rider");
            Console.WriteLine("2. Pay premium by cheque");
            Console.WriteLine("3. Cancel Policy");
            int option=Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                addRider(policy);
            }
            else if(option == 2)
            {
                payPremiumByCheque(policy);
            }
            else if (option==3)
            {
                cancelPolicy(policy);
            }


            if(policy is Car)
            {
                Console.WriteLine("Car");
            }
            else if(policy is Medical)
            {
                Console.WriteLine("Medical");
            }
            else if (policy is Travel)
            {
                Console.WriteLine("Travel");
            }
            Console.WriteLine("editPolicy end");
        }
        private void addRider(Policy policy)
        {
            Console.WriteLine("enter the no of the rider: ");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rider type: ");
            string rtype = Console.ReadLine();
            Console.WriteLine("Enter the amount: ");
            int ramount = Convert.ToInt32(Console.ReadLine());
            Rider r = new Rider(rno, rtype, ramount);
            policy.AddRider(r);
        }
        private void cancelPolicy(Policy policy)        // cancel policy
        {
            ownedPolicies.cancelPolicy(policy);             
        }
        private void payPremiumByCheque(Policy policy)
        {
            //implemetntation
        }
    }
}
