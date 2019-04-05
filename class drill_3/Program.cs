using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator_3 calculator_3 = new Calculator_3();

            Console.WriteLine("Please select a function. Double, Floor, Or Square");
            Console.WriteLine("Please type 'D', 'F' or 'S'.");
            string userChoice = Console.ReadLine();
            userChoice = userChoice.ToUpper();

            try
            {

                if (userChoice == "D")
                {
                    Console.WriteLine("Please select a number to double.");
                    int num_1 = Convert.ToInt32(Console.ReadLine());
                    calculator_3.DoubleNum(num_1);
                }
                else if (userChoice == "F")
                {
                    Console.WriteLine("Please select a decimal to find the floor of.");
                    double num_1 = Convert.ToDouble(Console.ReadLine());
                    calculator_3.Floor(num_1);
                }
                else if (userChoice == "S")
                {
                    Console.WriteLine("Please select a number to square.");
                    string num_1 = Console.ReadLine();
                    calculator_3.ConvertAndSquare(num_1);
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
