using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int>();
        intList.Add(45);
        intList.Add(36);
        intList.Add(77);
        intList.Add(98);
        intList.Add(35);
        intList.Add(10);
        intList.Add(9);
        intList.Add(68);
        intList.Add(91);

        Console.WriteLine("Please choose a number to divide by: ");

        try
        {
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            foreach (int i in intList)
            
            {
                Console.WriteLine(i / divisor);
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
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        finally
        {
            Console.ReadLine();
        }
        Console.WriteLine("Try//Catch block Finished - Continuing Program");
        Console.ReadKey();
    }
}
