using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOOAD_Ass.State;
using AOOAD_Ass.Agents;
using AOOAD_Ass.Policies;
using AOOAD_Ass.Agents;


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
                    ViewPolicies();
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

                            }
                        }
                        else if (opt == 2)
                        {
                            string user = Convert.ToString(Console.ReadLine());
                            for (int i = 0; i < AgentList.Count; i++)
                            {

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
            int clientid;
            Console.Write("Enter Client's ID: ");
            clientid = Convert.ToInt32(Console.ReadLine());
            int option;
            string severity;
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

            }
            else if (option == 3) //Travel
            {

            }
            else if(option == 0)
            {
                Console.WriteLine("Insurance Policy was not created.");
            }
            if (option != 0)
            {
                Console.WriteLine("Select terms and conditions: ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }


        static void ViewPolicies()
        {
            
            
        }
    }
}
