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

            try
            {
                calculator_3.HalfNumber(13);
                calculator_3.HalfNumber(13.00);
                calculator_3.HalfNumber("13");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
                return;
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
