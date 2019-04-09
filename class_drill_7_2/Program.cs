using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_7_2
{
    class Program
    {
        static void Main()
        {

            Employee<string> employee_1 = new Employee<string>() { FirstName = "Milton", LastName = "just Milton", Id = 1, IsWorking = true};
            Employee<int> employee_2 = new Employee<int>() { FirstName = "Tony", LastName = "Hawk", Id = 2, IsWorking = true };


            employee_1.things = new List<string>();
            employee_1.things.Add("Red stapler");
            employee_1.things.Add("Copy Machine"); 
            employee_1.things.Add("Glasses");

            employee_2.things = new List<int>();
            employee_2.things.Add(900);
            employee_2.things.Add(900);
            employee_2.things.Add(900);
            employee_2.things.Add(900);

            Console.WriteLine($"{employee_1.FirstName}, {employee_1.LastName}'s things: ");
            foreach (string thing in employee_1.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\n");

            Console.WriteLine($"{employee_2.FirstName} {employee_2.LastName}'s things: ");
            foreach (int thing in employee_2.things)
            {
                Console.WriteLine(thing);

            }

            Console.ReadKey();


            //Employee employee_1 = new Employee() { FirstName = "George", LastName = "Carlin", IsWorking = true };

            //IQuittable employee_2 = new Employee() { FirstName = "Mary", LastName = "Smith", IsWorking = true };
            //bool same = employee_1 == employee_2;
            //bool diff = employee_1 != employee_2;

            //Console.WriteLine(same);
            //Console.WriteLine(diff);



            //Console.WriteLine(employee_1.IsWorking);
            //employee_1.Quit();
            //Console.WriteLine(employee_1.IsWorking);

            // Console.WriteLine(employee_2.IsWorking);
            //employee_2.Quit();
            // Console.WriteLine(employee_2.IsWorking);

            Console.ReadKey();
        }
    }
}
