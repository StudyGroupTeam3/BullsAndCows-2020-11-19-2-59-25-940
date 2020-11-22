using BullsAndCows;
using System;
using System.Linq;

namespace BullsAndCowsRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SecretGenerator secretGenerator = new SecretGenerator();
            BullsAndCowsGame game = new BullsAndCowsGame(secretGenerator);

            const int maxCount = 6;
            var count = 0;
            while (game.CanContinue)
            {
                var input = Console.ReadLine();

                while (!CheckInput(ref input))
                {
                    Console.WriteLine("invalid input");
                    input = Console.ReadLine();
                }

                var output = game.Guess(input);
                Console.WriteLine(output);
                count++;

                if (output == "4A0B" || count == maxCount)
                {
                    break;
                }
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

            return input.ToArray().Distinct().Count() == input.Length;
        }
    }
}