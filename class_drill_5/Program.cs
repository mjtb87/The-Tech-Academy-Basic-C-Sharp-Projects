using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator_5 calculator_5 = new Calculator_5();
            double numberLog = 0;
            string userChoice = "";
            List<double> loggedNumbers = new List<double>();
            do
            {
                try
                {
                    Console.WriteLine("Please select a number to cut in half.");
                    double num_1 = Convert.ToDouble(Console.ReadLine());

                    calculator_5.HalfNum(num_1, out numberLog);
                    loggedNumbers.Add(numberLog);
                    Console.WriteLine("Past numbers divided: ");
                    foreach (double i in loggedNumbers)
                    {
                        Console.WriteLine(Static_class.PrintListItems(i));
                    }
                    Console.WriteLine("Do you want to continue dividing?");
                    Console.WriteLine("Please select Y or N");
                    userChoice = Console.ReadLine();
                    userChoice = userChoice.ToUpper();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please type a whole number.");
                    continue;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't divide by zero.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                finally
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            }
            while (userChoice == "Y");
        }
    }
}
