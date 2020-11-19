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
            var input = Console.ReadLine();
            while (game.CanContinue(input))
            {
                var output = game.Guess(input);
                Console.WriteLine(output);
            }

            Console.WriteLine("Game Over");
        }
    }
}