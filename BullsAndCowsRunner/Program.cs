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
            UserGuessValidator userGuessValidator = new UserGuessValidator();
            while (game.CanContinue())
            {
                var input = Console.ReadLine();

                if (!userGuessValidator.Validate(input))
                {
                    game.InvalidRun();
                    continue;
                }

                var output = game.Guess(input);
                Console.WriteLine(output);
            }

            Console.WriteLine("Game Over");
        }
    }
}