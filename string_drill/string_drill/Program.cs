using System;
using System.Text;


namespace string_drill

{
        class Program
        {
            static void Main()
            {
                StringBuilder paragraph = new StringBuilder();

                Console.WriteLine("Let's construct a zany story!");

                Console.WriteLine("Give me a goofy name! : ");
                String name = Console.ReadLine();
                paragraph.Append("Behold my arrival, for I am the Great Knight " + name + "!\n");
                paragraph.Append("Let me tell you a wonderful tale.\nOne you will not forget for sure!\n\n");

                Console.WriteLine("Give me a animal! : ");
                String animal = Console.ReadLine();
                paragraph.Append("I had ridden into the local town on my trusty battle " + animal + ".\n");

                Console.WriteLine("Give me a fictional animal! : ");
                String fictional_animal = Console.ReadLine();
                paragraph.Append("The town had given me word of a bounty,\nfor returning the head of the dreaded " + fictional_animal + ".\n\n");

                Console.WriteLine("Give me a fruit! : ");
                String fruit = Console.ReadLine();
                paragraph.Append("I walked a long hard walk through the treacherous " + fruit + " mountain.\n");

                Console.WriteLine("Give me a battle cry! : ");
                String battle_cry = Console.ReadLine();
                battle_cry = battle_cry.ToUpper();
                paragraph.Append("It was there at the peak that I found the beast in his lair.\n");
                paragraph.Append("I struck first as I let out my battle cry '" + battle_cry + "'!\n");

                Console.WriteLine("Give me an excited cheer! : ");
                String cheer = Console.ReadLine();
                cheer = cheer.ToUpper();
                paragraph.Append("It was an incredibly short battle,\nas my strike was the only strike.\n\n");
                paragraph.Append("After the conveniently short battle,\nI returned victorious and all of the townspeople cheered '" + cheer + "'!\n");

                Console.WriteLine("\n");
                Console.WriteLine(paragraph);
                Console.ReadKey();
            }
        }
}