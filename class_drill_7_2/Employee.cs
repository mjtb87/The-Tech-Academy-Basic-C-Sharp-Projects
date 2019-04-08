using System;
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
        public void Quit()
        {
            Console.WriteLine("Would you like to quit?: ");
            string userChoice = Console.ReadLine();
            userChoice = userChoice.ToUpper();
           do
            {
                if (userChoice == "Y")
                {
                    this.IsWorking = false;
                }
            }
            while (userChoice != "Y" && userChoice != "N");
        }

        public static bool operator ==(Employee employee_1, Employee employee_2)
        {
            if (employee_1.Id == employee_2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee_1, Employee employee_2)
        {
            if (employee_1.Id != employee_2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }    
}
