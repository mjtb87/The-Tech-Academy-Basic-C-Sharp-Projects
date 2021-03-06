﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_7
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public bool IsWorking { get; set; }

        public override void SayName()
        {
            base.SayName();
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine("Would you like to quit?: ");
            string userChoice = Console.ReadLine();
            userChoice = userChoice.ToUpper();
           do
            {
                if (userChoice == "Y")
                {
                    employee.IsWorking = false;
                }
            }
            while (userChoice != "Y" && userChoice != "N");
        }   
    }    
}
