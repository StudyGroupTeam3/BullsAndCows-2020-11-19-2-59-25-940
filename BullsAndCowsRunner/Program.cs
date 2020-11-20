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
            while (!game.IsInputValid(input))
            {
                Console.WriteLine("Wrong Input, input again! \n");
                input = Console.ReadLine();
            }

            while (game.CanContinue())
            {
                var output = game.Judge(input);
                if (output == "4A0B")
                {
                    Console.WriteLine(output);
                    break;
                }
                else
                {
                    Console.WriteLine(output);
                    input = Console.ReadLine();
                }
            }

            Console.WriteLine("Game Over");
        }
    }
}