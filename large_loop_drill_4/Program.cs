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


        //foreach (string game_1 in game_list)
        //{
        //    List<string> running_list = new List<string>();
        //    foreach (string game_2 in game_list)
        //    {
        //        running_list.Add(game_2);
        //    }

        //    if (running_list.Contains(game_1));
        //    {
        //        Console.WriteLine()
        //    }

        //}

        //foreach (string game_1 in game_list)
        //{

        //    if (game_list.Count<string>(game_1) > 1)
        //    {

        //    }
        //    List<string> running_list = new List<string>();
        //    foreach (string game_2 in game_list)
        //    {
        //        running_list.Add(game_2);
        //    }

        //    if (running_list.Contains(game_1)) ;
        //    {
        //        Console.WriteLine()
        //    }

        //}

        //foreach (string game_1 in game_list)
        //{
        //    List<string> running_list = new List<string>();
        //    int count = 0;
        //    foreach (string game_2 in game_list)
        //    {
        //        if (game_1 == game_2)
        //        {
        //            count++;
        //        }
        //    }
        //    if (count > 1)
        //    {
        //        Console.WriteLine(game_1 + " has more then 1 copy.");

        //    }
        //    else if (count == 1)
        //    {
        //        Console.WriteLine(game_1 + " has only one copy.");
        //    }
        //}

        //Console.ReadKey();

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



        //foreach (string game_1 in game_list)
        //{
        //    int distinctCount = game_list.Distinct().Count();

        //    if (distinctCount > 1)
        //    {
        //        Console.WriteLine("Dupe");
        //    }


        //List<string> running_list = new List<string>();
        //int count = 0;
        //foreach (string game_2 in game_list)
        //{
        //    if (game_1 == game_2)
        //    {
        //        count++;
        //    }
        //}
        //if (game_list<>.Distinct<string>(game_1))
        //{
        //    Console.WriteLine(game_1 + " is a ");

        //}
        //else if (count == 1)
        //{
        //    Console.WriteLine("Uni");
        //}


        //  Console.ReadKey();


        //Console.WriteLine(game_list.Distinct(game).ToString);
        //    Console.WriteLine("Dupe");




        //game_list.Contains();
        //{
        //    Console.WriteLine(game_list.IndexOf(game));
        //    Console.ReadKey();
        //}
        //else if (game_list.IndexOf(game) <= (game_list.Count - 2))
        //{
        //    Console.WriteLine("Not yet... Let's Keep looking");
        //}
        //else
        //{
        //    Console.WriteLine("Nope, not here at all!");
        //}


    }
}
