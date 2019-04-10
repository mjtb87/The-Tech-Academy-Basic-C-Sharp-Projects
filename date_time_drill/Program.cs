using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("You need the time... in the future...");
            Console.WriteLine("I can tell...");
            Console.WriteLine("Give me a number...now.");

            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddHours(userInput));

            Console.ReadKey();
        }
    }
}
