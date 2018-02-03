using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.State;

namespace AOOAD_Ass.Policies
{
    abstract class Policy
    {
        //basic attributes
        public string PolicyNo { get; set; }
        public string TermsCondition { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime MaturityDate { get; set; }
        List<Rider> RidersList = new List<Rider>();
        public bool PayOut { get; set; }
        public bool Periodic { get; set; }
        public float Premium { get; set; }

        //Operations
        public abstract float CalculatePayout();
        public void AddRider(Rider rider)
        {
            RidersList.Add(rider);
        }

        //states
        private PolicyState state;
        private PolicyState activeState;
        private PolicyState lapsedState;
        private PolicyState terminatedState;


        //Constructor
        public Policy()
        {
            activeState = new Active(this);
            lapsedState = new Lapsed(this);
            terminatedState = new Terminated(this);
        }

        // State Pattern methods
        public void SetState(PolicyState state)
        {
            this.state = state;
        }

        public void Lapsed()
        {
            state.LapsePolicy();
        }

        public void Activate()
        {
            state.ActivatePolicy();
        }

        public void Terminate()
        {
            state.TerminatePolicy();
        }

        public void Terminate(bool penalty)
        {
            state.TerminatePolicy(penalty);
        }

        public void Archive()
        {
            state.ArchivePolicy();
        }

        // My getters for the states so i dont have to keep recreating the objects inside my policyState
        public PolicyState GetActiveState() { return activeState; }
        public PolicyState GetLapsedState() { return lapsedState; }
        public PolicyState GetTerminatedState() { return terminatedState; }

        //Checks states
        public bool IsExisting()
        {
            if (state == terminatedState)
                return false;
            else
                return true;
        }

        public bool IsMatured()
        {
            if (DateTime.Now>MaturityDate || PayOut==true)
                return true;
            else
                return false;
        }

        public bool IsTerminated()
        {
            if (state == terminatedState)
                return true;
            else
                return false;
        }

        // End of State Pattern methods


        //Display policy details
        public void DisplayDetails()
        {
            Console.WriteLine("Policy No: {0}", PolicyNo);
            Console.WriteLine("Terms: {0}", TermsCondition);
            Console.WriteLine("Premium Amount: {0}", Premium);

            string payoutInfo;
            if (PayOut)
                payoutInfo = "Paid Out";
            else
                payoutInfo = "Not Paid Out yet";
            Console.WriteLine("Pay Out: {0}", payoutInfo);

            string currentstate = "";
            if(state == activeState)
            {
                currentstate = "Active";
            }
            else if (state == lapsedState)
            {
                currentstate = "Lapsed";
            }
            else if (state == terminatedState)
            {
                currentstate = "Terminated";
            }
            Console.WriteLine("Current state: {0}", currentstate);
        }

        //Other Operations
        public float CalculatePayOut()
        {
            float payout = 0;

            //Implementations

            return payout;
        }

        public void GenerateAlert()
        {
            Console.WriteLine("Generate Alert");
            Console.WriteLine("1. Email Alert");
            Console.WriteLine("2. Print Alert");
            Console.WriteLine("3. Email and Print Alert");

            Console.WriteLine();

            int opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            { 
                //Implementation
                Console.WriteLine("Email alert generation request sent to email server.");
            }
            else if (opt == 2)
            {
                //Implementation
                Console.WriteLine("Printed alert generation request sent to printer server.");
            }
            else if (opt == 3)
            {
                //Implementation
                Console.WriteLine("Email alert generation request sent to email server.");

                //Implementation
                Console.WriteLine("Printed alert generation request sent to printer server.");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }


    }
}
