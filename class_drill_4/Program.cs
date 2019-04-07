using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator_4 calculator_4 = new Calculator_4();


            Console.WriteLine("Please select two numbers.");
            Console.WriteLine("The first number you enter will be raised to the power of your second number.");
            Console.WriteLine("The second number you enter will be the power your first number is raised to.");
            Console.WriteLine("If left blank, the default value your first number will be raised to is 2.");
  

            try
            {
                int num_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Would you like to choose a second number?");
                Console.WriteLine("Please type Y for yes or N for n");

                string userChoice = Console.ReadLine();
                userChoice = userChoice.ToUpper();
                if (userChoice == "Y")
                {
                    Console.WriteLine("Please choose a second number: ");
                    int num_2 = Convert.ToInt32(Console.ReadLine());
                    calculator_4.Exponent(num_1, num_2);
                }
                else if (userChoice == "N")
                {
                    calculator_4.Exponent(num_1);
                }
                else
                {
                    Console.WriteLine("Please choose for the given options");
                }
            }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please type a whole number.");
                    return;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't divide by zero.");
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
        }
    }
}
