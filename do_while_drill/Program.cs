using System;

namespace switchStatmentLesson
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Hello number chooser! Time for some number fun!");
            int user_running_total = 0;
            string user_choice = "";
            do
            {
                Console.WriteLine("Please choose a number that you want to multiply: ");
                int user_base = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now, choose a number to multiply by: ");
                int user_multiple = Convert.ToInt32(Console.ReadLine());

                user_running_total = user_running_total + user_base * user_multiple;
                Console.WriteLine("Your running total is : " + user_running_total);

                Console.WriteLine("Please press any key to continue or type 'quit' to exit program: ");
                user_choice = Console.ReadLine();
            }
            while (user_choice != "quit");

        }
    }
}
