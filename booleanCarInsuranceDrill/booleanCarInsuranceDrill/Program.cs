using System;



    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lets see if you qualify for car insurance.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
    
            Console.WriteLine("What is your age?: ");
            string age = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?: ");
            Console.WriteLine("Please answer true or false. ");
            string dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?: ");
            string tickets = Console.ReadLine();

            Boolean qualifyForInsurance = (Convert.ToInt32(age) > 15) && (Convert.ToBoolean(dui) != true) && (Convert.ToInt32(tickets) < 3);

            Console.WriteLine("Qualified?: ");
            Console.WriteLine(qualifyForInsurance);
            Console.ReadLine();    
        }
    }
