using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a function.");
            Console.WriteLine("Please type 'D', 'H' or 'S'.");
            string userChoice = Console.ReadLine();
            userChoice = userChoice.ToUpper();


            try
            {
                if (userChoice == "D")
                {
                    Console.WriteLine("Please select a number to double.");
                    int num_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Calculator.DoubleNum(num_1));
                }
                else if (userChoice == "H")
                {
                    Console.WriteLine("Please select a number to cut in half.");
                    int num_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Calculator.HalfNum(num_1));
                }
                else if (userChoice == "S")
                {
                    Console.WriteLine("Please select a number to square.");
                    int num_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Calculator.SquareNum(num_1));
                }
                else
                {
                    Console.WriteLine("Please choose for the given options");
                }
                Console.ReadKey();
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
