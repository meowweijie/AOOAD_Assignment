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

        // End of State Pattern methods

    }
}
