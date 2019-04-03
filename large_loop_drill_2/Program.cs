using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> movie_list = new List<string>();
        movie_list.Add("the big lewbowski");
        movie_list.Add("the big lewbowski");
        movie_list.Add("airplane!");
        movie_list.Add("the naked gun");
        movie_list.Add("shawshank redemption");
        movie_list.Add("memento");
        movie_list.Add("mystery men");

        Console.WriteLine("Select a word or parts of a word to search for a movie title index.");
        string user_word_2 = Console.ReadLine();
        user_word_2 = user_word_2.ToLower();

        foreach (string movie in movie_list)
        {
            if (Convert.ToString(movie).Contains(user_word_2))
            {
                Console.WriteLine(movie_list.IndexOf(movie));
                Console.ReadKey();
            }
            else if (movie_list.IndexOf(movie) <= (movie_list.Count - 2))
            {
                Console.WriteLine("Not yet... Let's Keep looking");
            }
            else
            {
                Console.WriteLine("Nope, not here at all!");
            }

        }
    Console.ReadKey();
    }
}
