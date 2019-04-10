using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime todaysDate = DateTime.Now;
            int currentYear = todaysDate.Year;
                
            try
            {
                Console.WriteLine("Please for the love of God enter your age!");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0)
                {
                    throw new ArgumentException();
                }
                int birthYear = currentYear - age;
                Console.WriteLine(birthYear);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You can't be a negative age you loon!");
                Console.ReadKey();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong... somewhere...");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();  
        }
    }
}
