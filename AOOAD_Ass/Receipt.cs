using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.Policies;

namespace AOOAD_Ass
{
    class Receipt
    {
        private static int receiptCounter = 1;

        private string receiptNo;

        public string ReceiptNo
        {
            get { return receiptNo; }
            set { receiptNo = value; }
        }


        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private float amount;

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private Policy policy;

        public Policy Policy
        {
            get { return policy; }
            set { policy = value; }
        }

        public Receipt(float amt, Policy policy)
        {
            receiptNo = string.Format("R{0:0000}", receiptCounter);
            ++receiptCounter;
            date = DateTime.Today;
            amount = amt;
            this.policy = policy;
        }

    }
}
