using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> movie_quotes = new List<string>();
        movie_quotes.Add("these might be the droids your looking for.");
        movie_quotes.Add("what in gods name are you blabbering about.");
        movie_quotes.Add("she kidnapped herself man.");
        movie_quotes.Add("we have been frantically you dude.");
        movie_quotes.Add("she's my lady friend. i'm trying to help her conceive.");
        movie_quotes.Add("do you want a toe? i can get you a toe.");
        movie_quotes.Add("no donny, these men are nihilist.");

        Console.WriteLine("select a word or parts of a word to search for the index of a movie quote");
        string user_word = Console.ReadLine();
        user_word = user_word.ToLower();
        foreach (string movie_quote in movie_quotes)
        {
            if (Convert.ToString(movie_quote).Contains(user_word))
            {
                Console.WriteLine(movie_quotes.IndexOf(movie_quote));       
                Console.ReadKey();
                return;
            }
            else if (movie_quotes.IndexOf(movie_quote) < (movie_quotes.Count - 1))
            {
                Console.WriteLine("Not yet... let's keep looking");
            }
            else
            {
                Console.WriteLine("Nope, not here at all!");
            }

        }
    }
}
