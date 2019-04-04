using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_method_drill_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator_2 calculator_2 = new Calculator_2();
            Console.WriteLine("Please select two whole numbers, one to double and the second to print.");
    
            try
            {
                int num_1 = Convert.ToInt32(Console.ReadLine());
                int num_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                calculator_2.DoubleNum(num_1: num_1, num_2: num_2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
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
