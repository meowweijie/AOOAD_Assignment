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
            Console.WriteLine("1. Create Insurance Policy.");
            Console.WriteLine("2. View all policies.");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(option==1)
            {

            }
            else if(option == 2)
            {
                ViewPolicies();
            }
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
            Console.WriteLine();
        }
    }
}
