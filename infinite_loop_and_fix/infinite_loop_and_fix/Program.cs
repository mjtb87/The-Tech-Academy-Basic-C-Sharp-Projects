using System;
using System.Collections.Generic;
using System.Linq;

//This part of the program has the infinite loop.
class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Jack", "Matt", "John", "Jacob", "Kermit", "Fozzy", "Gonzo", "Animal", "Sam"};
        string greeting = "Oh... hello there, ";


        for (int i = 0; i < names.Length;)
        {
            Console.WriteLine(greeting + names[i] + ".");
        }

        Console.ReadKey();
    }
}

//The program below is the same as about, but with the fix for the infinite loop. 
class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Jack", "Matt", "John", "Jacob", "Kermit", "Fozzy", "Gonzo", "Animal", "Sam" };
        string greeting = "Oh... hello there, ";


        for (int i = 0; i < names.Length; i++)//<<<<<The fix is right here. We needed to increment out count by 1 each loop.
        {
            Console.WriteLine(greeting + names[i] + ".");
        }

        Console.ReadKey();
    }
}

