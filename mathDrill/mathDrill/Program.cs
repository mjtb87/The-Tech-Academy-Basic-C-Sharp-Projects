using System;



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I'll multiply it by 50!: ");
            string multiplyChoice = Console.ReadLine();
            int multiplyResult = 50 * Convert.ToInt32(multiplyChoice);
            Console.WriteLine(multiplyResult);
            Console.ReadLine();

            Console.WriteLine("Give me a number and I'll add 25 to it!: ");
            string addChoice = Console.ReadLine();
            int addResult = 25 + Convert.ToInt32(addChoice);
            Console.WriteLine(addResult);
            Console.ReadLine();

            Console.WriteLine("Give me a number and I'll divide it by 12.5!: ");
            string divideChoice = Console.ReadLine();
            double divideResult = Convert.ToDouble(divideChoice) / 12.5;
            Console.WriteLine(divideResult);
            Console.ReadLine();

            Console.WriteLine("Give me a number and I'll check to see if it's greater then 50!: ");
            string checkChoice = Console.ReadLine();
            Boolean checkResult = 50 <= Convert.ToInt32(checkChoice);
            Console.WriteLine(checkResult);
            Console.ReadLine();

            Console.WriteLine("Give me a number and give you the remainder after being divided by 7!: ");
            string remainderChoice = Console.ReadLine();
            int remainderResult = Convert.ToInt32(remainderChoice) % 7;
            Console.WriteLine(remainderResult);
            Console.ReadLine();
       
    }
}

