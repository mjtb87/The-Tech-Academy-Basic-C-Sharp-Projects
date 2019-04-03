using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] stringArray = { "Mark", "it", "zero!" };

        int user_selection = 0;

        do
        {
            Console.WriteLine("Please select an index number from numbers 0 to " + (stringArray.Length - 1) + ".");
            user_selection = Convert.ToInt32(Console.ReadLine());

        }
        while (user_selection > stringArray.Length - 1 || user_selection < 0);

        Console.WriteLine("You chose: " + stringArray[user_selection] + ".");

        int[] intArray = { 0, 1, 1, 2, 3, 5, 8, 13, 21 };

        int user_selection_2 = 0;

        do
        {
            Console.WriteLine("Please select an index number from numbers 0 to " + (intArray.Length - 1) + ".");
            user_selection_2 = Convert.ToInt32(Console.ReadLine());

        }
        while (user_selection_2 > intArray.Length - 1 || user_selection_2 < 0);

        Console.WriteLine("You chose: " + intArray[user_selection_2] + ".");

        List<string> strList = new List<string>();

        strList.Add("Do");
        strList.Add("you");
        strList.Add("see");
        strList.Add("What");
        strList.Add("happens");
        strList.Add("Larry?");

        int user_selection_3 = 0;

        do
        {
            Console.WriteLine("Please select an index number from numbers 0 to " + (strList.Count - 1) + ".");
            user_selection_3 = Convert.ToInt32(Console.ReadLine());

        }
        while (user_selection_3 > strList.Count - 1 || user_selection_3 < 0);

        Console.WriteLine("You chose: " + strList[user_selection_3] + ".");
        Console.ReadKey();
    }
}

