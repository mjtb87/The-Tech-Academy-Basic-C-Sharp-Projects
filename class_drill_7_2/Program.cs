using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee_1 = new Employee() { FirstName = "George", LastName = "Carlin", IsWorking = true };
            IQuittable employee_2 = new Employee() { FirstName = "Mary", LastName = "Smith", IsWorking = true };

            Console.WriteLine(employee_1.IsWorking);
            employee_1.Quit();
            Console.WriteLine(employee_1.IsWorking);

           // Console.WriteLine(employee_2.IsWorking);
            employee_2.Quit();
           // Console.WriteLine(employee_2.IsWorking);

            Console.ReadKey();
        }
    }
}
