using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.State;
using AOOAD_Ass.Agents;
using AOOAD_Ass.Policies;

//Uncertainties: Due date only for Periodic?

namespace AOOAD_Ass
{
    class Program
    {
        static List<Policy> PolicyList;
        static List<Client> ClientList;
        static List<Agent> AgentList;
        static List<Rider> RiderList;
        static void Main(string[] args)
        {
            // Test data
            PolicyList = new List<Policy>();
            ClientList = new List<Client>();
            AgentList = new List<Agent>();
            RiderList = new List<Rider>();

            initRiderList(RiderList);

            Medical mpolicy = new Medical();
            Travel tpolicy = new Travel();
            Car cpolicy = new Car();



            //Main Menu
            int option;
            MainMenu();
            Console.Write("Option: ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (option == 1)
            {
                CreatePolicy(PolicyList, RiderList);
            }
            else if (option == 2)
            {
                viewPolicies();
            }
        }

        static void MainMenu()
        {
            Console.WriteLine("1. Create Insurance Policy.");
            Console.WriteLine("2. View Policies.");
            Console.WriteLine("3. Exit.");

            Console.WriteLine();

        }

        static void CreatePolicyMenu()
        {
            //Menu for the Policy
            Console.WriteLine("Types of Policies");
            Console.WriteLine("1. Medical Insurance Policy");
            Console.WriteLine("2. Car Insurance Policy");
            Console.WriteLine("2. Travel Insurance Policy");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Select type of policy: ");
        }

        static void initRiderList(List<Rider> riderList)
        {
            string riderType1 = "RiderA";
            string riderType2 = "RiderB";
            string riderType3 = "RiderC";
            float amount1 = 500;
            float amount2 = 1000;
            float amount3 = 2000;
            Rider rider1 = new Rider(1, riderType1, amount1);
            Rider rider2 = new Rider(2, riderType2, amount2);
            Rider rider3 = new Rider(3, riderType3, amount3);
        }

        static void CreatePolicy(List<Policy> policyList, List<Rider> riderList)
        {
            //Variables needed
            int clientid;
            int option;
            string policyType = "";
            string severity = "";
            string terms = "";
            DateTime dueDate = new DateTime();
            string hasMaturityDate = "";
            DateTime maturityDate = new DateTime();
            int rider = 0;
            bool periodic = false;
            bool payout = false;
            string premium = "";
            float payment = 0;
            int months = 0;

            //Before Policy
            Console.Write("Enter Client's ID: ");
            clientid = Convert.ToInt32(Console.ReadLine());
            CreatePolicyMenu();
            option = Convert.ToInt32(Console.ReadLine());

            //Policy 
            if (option == 1) //Medical
            {
                policyType = "Medical";
                Console.Write("Enter Injury Severity(Low, Medium, High): ");
                severity = Console.ReadLine();
                if (severity == "Low")
                {
                    //implementation
                }
                else if (severity == "Medium")
                {
                    //implementation
                }
                else if (severity == "High")
                {
                    //implementation
                }
                else
                {
                    Console.WriteLine("Error! Please enter only Low, Medium or High.");
                }
                Console.WriteLine("Terms and Conditions Test"); // Add the terms and condition thing here.
            }
            else if (option == 2) //Car
            {
                policyType = "Car";
                Console.WriteLine("Terms and Conditions Test"); // Add the terms and condition thing here.
            }
            else if (option == 3) //Travel
            {
                policyType = "Travel";
                Console.WriteLine("Terms and Conditions Test"); // Add the terms and condition thing here.
            }
            else if (option == 0) //Exit
            {
                Console.WriteLine("Insurance Policy was not created.");
            }

            if (option != 0) // Rest of Create Policy
            {
                Console.Write("Select terms and conditions: ");
                terms = Console.ReadLine();
                Console.Write("Select type of premium(One-time/Periodic): ");
                premium = Console.ReadLine();
                if (premium == "One-time")
                {
                    Console.Write("Enter the total cost of payment: ");
                    payment = Convert.ToInt32(Console.ReadLine());
                }
                else if (premium == "Periodic") //When it is Periodic
                {
                    Console.Write("Enter the number of months of payment: ");
                    months = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter payment to be made each month: ");
                    payment = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter due date of payment(YYYY-MM-DD): ");
                    dueDate = DateTime.Parse(Console.ReadLine());
                    periodic = true;
                }
                Console.Write("Does the policy have a maturity date?(Y/N): ");
                hasMaturityDate = Console.ReadLine();
                if (hasMaturityDate == "Y") // Have Maturity Date
                {
                    Console.Write("Enter policy maturity date: ");
                    maturityDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Policy holder will be given a lump sum payout.");
                }
                Console.Write("Does the policy have optional riders?(Y/N): ");
                if (Console.ReadLine() == "Y") //Optional Rider
                {
                    for (int i = 0; i < riderList.Count; i++)
                    {
                        Console.WriteLine(riderList[i]);
                        Console.Write("Select your type of rider: ");
                        rider = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insurance coverage has increased.");
                        //Should I increase the coverage here... or deduct later?
                    }

                }
                Console.WriteLine("ClientID: {0}", clientid);
                Console.WriteLine("Policy Type: {0}", policyType);
                if (policyType == "Medical")
                {
                    Console.WriteLine("Severity: {0}", severity);
                }
                Console.WriteLine("Terms & Conditions: {0}", terms);
                Console.WriteLine("Premium: {0}", premium);
                if (premium == "One-time")
                    Console.WriteLine("Payment: {0}", Convert.ToString(payment));
                else
                {
                    Console.WriteLine("Month: {0}", Convert.ToString(months));
                    Console.WriteLine("Payment: {0}", Convert.ToString(payment));
                    Console.WriteLine("Due Date: {0}", Convert.ToString(dueDate));
                }
                if (hasMaturityDate == "Y")
                    Console.WriteLine("Maturity Date: {0}", Convert.ToString(maturityDate));
                if (rider != 0)
                {
                    for (int i = 0; i < riderList.Count; i++)
                        Console.WriteLine("Rider: {0}", riderList[i].riderType);
                }
                Console.Write("Confirm creation of policy?(Y/N): ");
                if (Console.ReadLine() == "Y")
                {
                    Console.WriteLine("Insurance Policy created.");
                    if (option == 1) //Medical
                    {
                        for (int i = 0; i < policyList.Count; i++)
                        {
                            Policy p = new Medical(severity);
                        }
                    }
                    else if (option == 2) //Car
                    {
                        for (int i = 0; i < policyList.Count; i++)
                        {
                            Policy p = new Car();
                        }
                    }
                    else if (option == 3) //Travel
                    {
                        for (int i = 0; i < policyList.Count; i++)
                        {
                            Policy p = new Travel();
                        }
                    }
                    payout = true;
                }
                else
                {
                    Console.WriteLine("Insurance Policy was not created.");
                }
            }
            Console.ReadKey();
        }
        static void viewPolicies()
        {
            int opt;
            Console.WriteLine("-------------- View Policies ------------");
            Console.WriteLine("[1] Display all policies");
            Console.WriteLine("[2] Filter policies");
            Console.WriteLine("[3] View a specific policy");
            Console.Write("Option: ");
            opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // User selects display all policies option
            if (opt == 1)
            {
                //Implementation
                Console.WriteLine("All policies in system is displayed.");
            }
            // Filter policies
            else if (opt == 2)
            {
                Console.WriteLine("----------- Filter Policies -------------");
                Console.WriteLine("[1] Client");
                Console.WriteLine("[2] Agent");
                Console.WriteLine("Option: ");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                string id = "";
                Client client = null;
                Agent agent = null;
                // Filter by Client
                if (opt == 1)
                {
                    Console.Write("Enter Client No: ");
                    id = Convert.ToString(Console.ReadLine());
                    foreach(Client c in ClientList)
                    {
                        if (c.ClientNo == id)
                            client = c;
                    }
                }
                // Filter by Agent
                else if (opt == 2)
                {
                    Console.Write("Enter Agent Number: ");
                    id = Convert.ToString(Console.ReadLine());
                    foreach(Agent a in AgentList)
                    {
                        if (a.AgentNo == id)
                            agent = a;
                    }
                }

                Console.WriteLine("------------ Filter Types -------------");
                Console.WriteLine("[1] Existing");
                Console.WriteLine("[2] Terminated");
                Console.WriteLine("[3] Matured");
                Console.Write("Option: ");
                opt = Convert.ToInt32(Console.ReadLine());
                // Getting the type
                string type = "";
                if (opt == 1)
                    type = "Existing";
                else if (opt == 2)
                    type = "Terminated";
                else if (opt == 3)
                    type = "Matured";

                while (true)
                {
                    // Checking and displaying the policies
                    if (client != null)
                        client.ViewPolicies(type);
                    else if (client != null)
                        agent.ViewPolicies(type);

                    Console.WriteLine("[0] Exit");
                    Console.Write("Option: ");
                    string polNo = Console.ReadLine();
                    if (polNo != "0")
                    {
                        Policy p = null;
                        if (client != null)
                            p = client.FindPolicy(polNo);
                        else if (agent != null)
                            p = agent.FindPolicy(polNo);

                        p.DisplayDetails();
                        Console.WriteLine("--------- Action -------------");
                        Console.WriteLine("1. Edit Policy");
                        Console.WriteLine("2. Generate Alert");
                        Console.WriteLine("3. Cancel");
                        Console.Write("Option: ");
                        opt = Convert.ToInt32(Console.ReadLine());

                        if (opt == 1)
                            Console.WriteLine("Call edit policy use case");
                        else if (opt == 2)
                            p.GenerateAlert();
                        else if (opt == 3)
                            continue;
                    }
                    // Selected the exit option (Alt Flow 17)
                    else
                        break;
                }
            }
            // User selects view a specific policy option
            else if (opt == 3)
            {
                Console.Write("Enter the policyNo: ");
                string polNo = Console.ReadLine();

                Policy policy = null;
                foreach(Policy p in PolicyList)
                {
                    if (p.PolicyNo == polNo)
                        policy = p;
                }
                policy.DisplayDetails();
            }
        }
    }
}
