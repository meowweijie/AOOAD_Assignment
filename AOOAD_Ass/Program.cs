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
            CreatePolicy();
        }

        static void MainMenu()
        {
            int option;
            Console.WriteLine();
            do
            {
                
                Console.WriteLine("1. Create Insurance Policy.");
                Console.WriteLine("2. View all policies.");
                Console.WriteLine("3. Exit.");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (option == 1)
                {

                }
                else if (option == 2)
                {
                    ViewPolicies();
                }
            } while (option != 0);
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
            if(option == 1) //Medical
            {
                Console.Write("Enter Injury Severity(Low, Medium, High): ");
                severity = Console.ReadLine();
                if(severity == "Low")
                {

                }
                else if (severity == "Medium")
                {

                }
                else if (severity == "High")
                {

                }
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
            Console.WriteLine();
            Console.ReadKey();
        }


        static void ViewPolicies()
        {
            int opt;
            Console.WriteLine("View Policies options:");
            Console.WriteLine("1. View all policies");
            Console.WriteLine("2. Filter Policies");
            Console.WriteLine("3. View a specific policy");
            opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(opt==1)
            {
                //Implementation
                Console.WriteLine("All policies in system is displayed.");
            }
            else if(opt==2)
            {
                Console.WriteLine("1. Client");
                Console.WriteLine("2. Agent");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if(opt==1)
                {
                    string user = Convert.ToString(Console.ReadLine());
                }
                else if(opt==2)
                {

                }
            }
            else if(opt==3)
            {

            }
            
        }
    }
}
