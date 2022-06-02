using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            var faveNumber = r.Next(1, 1000);

            Console.WriteLine("Guess my favorite number...");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > faveNumber)
            {
                Console.WriteLine("Too high!");
            }

            else if (userInput < faveNumber)
            {
                Console.WriteLine("Too low!");
            }

            else
            {
                Console.WriteLine("You got it!");
            }


            Console.WriteLine("What is your favorite school subject?");
            string faveSubject = Console.ReadLine();

            switch (faveSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome!");
                    break;
                case "english":
                    Console.WriteLine("English is important!");
                    break;
                case "science":
                    Console.WriteLine("Science is so much fun!");
                    break;
                case "music":
                    Console.WriteLine("Music is the king of all subjects!!!");
                    break;
                case "history":
                    Console.WriteLine("Meh...");
                    break;
                default:
                    Console.WriteLine("That's cool, too, I guess...");
                    break;

            }

        }
    }
}
