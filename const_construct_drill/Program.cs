using System;
using System.Collections.Generic;


namespace const_construct_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string restaurantName = "Fine Cuisine Land";

            var chef_1 = new Chef("Chuck");
            var chef_2 = new Chef("Al", "head");
      
            Console.WriteLine($"Welcome to {restaurantName}, a fine place to eat and cry.");
            Console.WriteLine("Enjoy a fine feast, handcrafted by two people we found.");
            Console.WriteLine($"{chef_1.Name} is our fine {chef_1.Rank} chef.");
            Console.WriteLine($"and {chef_2.Name} is our glorious {chef_2.Rank} chef.");
            Console.WriteLine($"{restaurantName}, where you get what you paid for!");

            Console.ReadKey();       
        }
        public class Chef
        {
            public Chef(string name) : this(name, "station"){}

            public Chef(string name, string rank)
            {
                Name = name;
                Rank = rank;
            }
            public string Name { get; set; }
            public string Rank { get; set; }
        }

    }
}
