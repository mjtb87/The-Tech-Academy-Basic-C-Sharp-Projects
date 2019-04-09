using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_drill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a day of the week: ");
            try
            {
                DaysOfTheWeek userInput = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), UppercaseFirst(Console.ReadLine()));
                Console.WriteLine(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter the actual day of the week.");
                return;
            }
            finally
            {
                Console.ReadKey();
            }
        }
        static string UppercaseFirst(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
