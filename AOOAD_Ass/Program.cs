﻿using System;
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
        }

        void MainMenu()
        {
            Console.WriteLine("1. Create Insurance Policy.");
        }

        void CreateInsurancePolicy()
        {
            int option;
            Console.WriteLine("Types of Policies");
            Console.WriteLine("1. Medical Insurance Policy /b");
            Console.WriteLine("2. Car Insurance Policy");
            Console.WriteLine("2. Travel Insurance Policy");
            Console.WriteLine("Select type of policy: ");
            option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
