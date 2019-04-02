using System;

namespace switchStatmentLesson
{
    class Program
    {
        static void Main()
        {
            Random numberGenerator = new Random();
            int number_of_guesses = 3;
            int computer_number = numberGenerator.Next(1, 11);

            Console.WriteLine("I wanna play a game...");
            Console.WriteLine("You have three guesses at my secretly choosen number between one and ten.");
            Console.WriteLine("Begin!");
            while (number_of_guesses > 0)
            {
                Console.WriteLine("Guess number " + number_of_guesses + ":");
                int user_guess = Convert.ToInt32(Console.ReadLine());
                if (user_guess == computer_number)
                {
                    Console.WriteLine("You... how could you have defeated me. I must put more thought into my planning");
                    Console.WriteLine("Press any key to walk away unphased");
                    Console.ReadKey();
                    return;
                }
                number_of_guesses = number_of_guesses - 1;       
            }

            Console.WriteLine("You have failed and now your life is mine. You came to the wrong carnival!");
            Console.WriteLine("Press any key to forfeit your soul!");
            Console.ReadKey();
        }
    }
}
