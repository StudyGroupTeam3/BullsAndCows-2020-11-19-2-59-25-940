using System;
using BullsAndCows;

namespace BullsAndCowsRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SecretGenerator secretGenerator = new SecretGenerator();
            BullsAndCowsGame game = new BullsAndCowsGame(secretGenerator);
            while (game.CanContinue)
            {
                var input = Console.ReadLine();
                if (!game.IsInputValid(input))
                {
                    Console.WriteLine("Wrong Input, input again");
                    continue;
                }

                var output = game.Guess(input);
                Console.WriteLine(output);
                if (output == "4A0B")
                {
                    Console.WriteLine("You win");
                    break;
                }

                game.CountInputTimes();
            }

            Console.WriteLine("Game Over");
        }
    }
}