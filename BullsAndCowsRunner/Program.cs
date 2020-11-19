using System;
using System.Data.SqlTypes;
using System.Linq;
using BullsAndCows;

namespace BullsAndCowsRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SecretGenerator secretGenerator = new SecretGenerator();
            BullsAndCowsGame game = new BullsAndCowsGame(secretGenerator);
            while (game.CanContinue < game.GameMaxCount)
            {
                var input = Console.ReadLine();

                while (!CheckInput(ref input))
                {
                    Console.WriteLine("invalid input");
                    input = Console.ReadLine();
                }

                var output = game.Guess(input);
                Console.WriteLine(output);

                if (output == "4A0B")
                {
                    break;
                }

                game.CanContinue++;
            }

            Console.WriteLine("Game Over");
        }

        private static bool CheckInput(ref string input)
        {
            input = input.Replace(" ", string.Empty);

            if (input.Length != 4)
            {
                return false;
            }

            if (input.ToArray().Distinct().Count() != input.Length)
            {
                return false;
            }

            return true;
        }
    }
}