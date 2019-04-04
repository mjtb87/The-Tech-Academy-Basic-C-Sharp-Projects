using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {

        List<string> game_list = new List<string>();
        game_list.Add("final fantasy 7");
        game_list.Add("final fantasy 7");
        game_list.Add("legacy of kain blood omen");
        game_list.Add("metal gear solid");
        game_list.Add("metal gear solid");
        game_list.Add("twisted metal 2");
        game_list.Add("sonic the hedgehog");
        game_list.Add("final fantasy 10");

        List<string> running_list = new List<string>();

        foreach (string game_1 in game_list)
        {


            if (running_list.Contains(game_1))
            {
                Console.WriteLine(game_1 + " Duplicate");
            }
            else
            {
                Console.WriteLine(game_1);
            }

            running_list.Add(game_1);
        }

        Console.ReadKey();
    }
}
