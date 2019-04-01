using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("What is your package weight?: ");
        double packageWeight = Convert.ToDouble(Console.ReadLine());

        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            Console.WriteLine("Click anykey to end.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("What is your package width?:  ");
        double packageWidth = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your package height?: ");
        double packageHeight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your package length?: ");
        double packageLength = Convert.ToDouble(Console.ReadLine());

        double dimensionsSum = (packageLength + packageWidth + packageHeight);

        if (dimensionsSum > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.WriteLine("Click anykey to end.");
            Console.ReadKey();
            return;
        }
        double quote = ((dimensionsSum * packageWeight) / 100);

        Console.WriteLine("Your estimated shipping total is $" + quote + ".");
        Console.ReadKey();
    }
}