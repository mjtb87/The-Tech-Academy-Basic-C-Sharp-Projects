using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logging_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey you, over there.");
            Console.WriteLine("Yea, you.");
            Console.WriteLine("I need a number from you...");
            Console.WriteLine("\n\nImmediately!");

            try
            {
                string userNumber = Console.ReadLine();
                File.WriteAllText(@"C:\Users\mjtb8\Documents\C#\C# scrap\numbers_log.txt", userNumber);
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
            Console.WriteLine("Thanks... foolish mortal.");
        }
    }
}
