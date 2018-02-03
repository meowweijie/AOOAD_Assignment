using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.State;
using AOOAD_Ass.Agents;
using AOOAD_Ass.Policies;


namespace AOOAD_Ass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test data
            List<Policy> PolicyList = new List<Policy>();
            List<Client> ClientList = new List<Client>();
            List<Agent> AgentList = new List<Agent>();

            Medical mpolicy = new Medical();
            Travel tpolicy = new Travel();
            Car cpolicy = new Car();

            CreatePolicy();
            

            //Main Menu
            int option;
            do
            {
                MainMenu();
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (option == 1)
                {

                }
                else if (option == 2)
                {
                    
                    int opt;
                    Console.WriteLine("View Policies options:");
                    Console.WriteLine("1. View all policies");
                    Console.WriteLine("2. Filter Policies");
                    Console.WriteLine("3. View a specific policy");
                    opt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (opt == 1)
                    {
                        //Implementation
                        Console.WriteLine("All policies in system is displayed.");
                    }
                    else if (opt == 2)
                    {
                        Console.WriteLine("1. Client");
                        Console.WriteLine("2. Agent");
                        opt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (opt == 1)
                        {
                            Client client = null;
                            string user = Convert.ToString(Console.ReadLine());
                            for (int i = 0; i<ClientList.Count;i++)
                            {
                                if(ClientList[i].ClientNo==user)
                                {
                                    client = ClientList[i];
                                }
                            }

                            if(client != null)
                            {
                                string type = ViewFilters();
                                client.ViewPolicies(type);

                                Console.WriteLine();
                                Console.Write("Enter policy no. to view: ");
                                string id = Console.ReadLine();

                                Policy p = client.FindPolicy(id);

                                PolicyMenu(p);
                            }

                            

                        }
                        else if (opt == 2)
                        {
                            Agent agent = null;
                            string user = Convert.ToString(Console.ReadLine());
                            for (int i = 0; i < AgentList.Count; i++)
                            {
                                if (AgentList[i].AgentNo == user)
                                {
                                    agent = AgentList[i];
                                }
                            }

                            if (agent != null)
                            {
                                string type = ViewFilters();
                                agent.ViewPolicies(type);

                                Console.WriteLine();
                                Console.Write("Enter policy no. to view: ");
                                string id = Console.ReadLine();
                                Policy p =  agent.FindPolicy(id);

                                PolicyMenu(p);
                            }

                            

                        }
                    }
                    else if (opt == 3)
                    {

                    }
                }


            } while (option != 0);

        }

        static void MainMenu()
        {
            Console.WriteLine("1. Create Insurance Policy.");
            Console.WriteLine("2. View all policies.");
            Console.WriteLine("3. Exit.");

            Console.WriteLine();
            
        }

        static void CreatePolicy()
        {
            //Variables needed
            int clientid;
            int option;
            string policyType = "";
            string severity = "";
            string terms = "";
            string hasMaturityDate = "";
            DateTime maturityDate;
            bool periodic;
            bool payout;
            List<Rider> riderList = new List<Rider>();
            string premium = "";
            float payment;
            int months;

            //Before Policy
            Console.Write("Enter Client's ID: ");
            clientid = Convert.ToInt32(Console.ReadLine());
     
            //Menu for the Policy
            Console.WriteLine("Types of Policies");
            Console.WriteLine("1. Medical Insurance Policy");
            Console.WriteLine("2. Car Insurance Policy");
            Console.WriteLine("2. Travel Insurance Policy");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Select type of policy: ");        
            option = Convert.ToInt32(Console.ReadLine());

            //Policy 
            if(option == 1) //Medical
            {
                policyType = "Medical";
                Console.Write("Enter Injury Severity(Low, Medium, High): ");
                severity = Console.ReadLine();
                if(severity == "Low")
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
                Console.WriteLine(); // Add the terms and condition thing here.
            }
            else if (option == 2) //Car
            {
                policyType = "Car";
                Console.WriteLine(); // Add the terms and condition thing here.
            }
            else if (option == 3) //Travel
            {
                policyType = "Travel";
                Console.WriteLine(); // Add the terms and condition thing here.
            }
            else if(option == 0)
            {
                Console.WriteLine("Insurance Policy was not created.");
            }
            if (option != 0)
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
                else if (premium == "Periodic")
                {
                    Console.Write("Enter the number of months of payment: ");
                    months = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter payment to be made each month: ");
                    payment = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Does the policy have a maturity date?(Y/N): ");
                hasMaturityDate = Console.ReadLine();
                if(hasMaturityDate == "Y")
                {
                    Console.Write("Enter policy maturity date: ");
                    maturityDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Policy holder will be given a lump sum payout.");
                }
                Console.WriteLine("ClientID: {0}", clientid);
                Console.WriteLine("Policy Type: {0}", policyType);
                if(policyType == "Medical")
                {
                    Console.WriteLine("Severity: {0}", severity);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.ReadKey();
        }


        static void PolicyMenu(Policy p)
        {
            

            Console.WriteLine("1. Edit Policy");
            Console.WriteLine("2. Generate Alert");
            Console.WriteLine("3. Exit");

            Console.WriteLine();

            int opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                
            }
            else if (opt == 2)
            {
                
            }
            else if (opt == 3)
            {
                
            }
            else
            {
                
            }

        }

        static string ViewFilters()
        {
            Console.WriteLine("1. View Existing");
            Console.WriteLine("2. View Matured");
            Console.WriteLine("3. View Terminated");

            Console.WriteLine();

            int opt = Convert.ToInt32(Console.ReadLine());
            if(opt ==1)
            {
                return "Existing";
            }
            else if(opt==2)
            {
                return "Matured";
            }
            else if(opt==3)
            {
                return "Terminated";
            }
            else
            {
                return "";
            }
        }
    }
}
