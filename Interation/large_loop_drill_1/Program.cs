using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Shirley", "Bill", "Carl", "Chuck", "Leroy" };
        string user_greeting = "";

        do
        {
            Console.WriteLine("You don't you say hello to all my friends?");
            user_greeting = Console.ReadLine();
        }
        while (user_greeting != "hello");

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(user_greeting + " " + names[i]);
        }
        Console.ReadKey();
    }
}
