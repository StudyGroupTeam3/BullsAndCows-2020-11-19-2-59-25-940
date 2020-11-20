using System;
using System.Linq;
using BullsAndCows;
using BullsAndCowsTest;

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
                var message = game.GetMessage(input);
                int count = 0;
                if (message == "OK")
                {
                    var output = game.Guess(input);
                    count++;
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine(message);
                }

                if (count == 6)
                {
                    break;
                }
            }

            Console.WriteLine("Game Over");
        }
    }
}
