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
        public string policyNo { get; set; }
        public string termsCondition { get; set; }
        public DateTime maturityDate { get; set; }
        List<Rider> ridersList = new List<Rider>();
        public bool payOut { get; set; }
        public bool periodic { get; set; }
        public float premium { get; set; }

        //Operations
        public abstract float calculatePayout();
        public void addRider(Rider rider)
        {
            ridersList.Add(rider);
        }

        //states
        private PolicyState state;
        private PolicyState activeState;
        private PolicyState lapsedState;
        private PolicyState terminatedState;

        public Policy()
        {
            activeState = new Active(this);
            lapsedState = new Lapsed(this);
            terminatedState = new Terminated(this);
        }

        // State Pattern methods
        public void setState(PolicyState state)
        {
            this.state = state;
        }
        public void Lapsed()
        {
            state.lapsePolicy();
        }
        public void Activate()
        {
            state.activatePolicy();
        }
        public void Terminate(bool penalty)
        {
            state.terminatePolicy(penalty);
        }
        public void Archive()
        {
            state.archivePolicy();
        }
        // My getters for the states so i dont have to keep recreating the objects inside my policyState
        public PolicyState getActiveState() { return activeState; }
        public PolicyState getLapsedState() { return lapsedState; }
        public PolicyState getTerminatedState() { return terminatedState; }
        // End of State Pattern methods

    }
}
