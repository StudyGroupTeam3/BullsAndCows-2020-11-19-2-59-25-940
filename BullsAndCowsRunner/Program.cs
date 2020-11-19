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
            TestSecretGenerator secretGenerator = new TestSecretGenerator();
            BullsAndCowsGame game = new BullsAndCowsGame(secretGenerator);
            //Console.WriteLine(secretGenerator.GenerateSecret());
            for (int i = 0; i < 6; i++)
            {
                var input = Console.ReadLine();
                var output = game.Guess(input);
                Console.WriteLine(output);
            }

            //while (game.CanContinue)
            //{
            //    var input = Console.ReadLine();
            //    var output = game.Guess(input);
            //    Console.WriteLine(output);
            //}

            Console.WriteLine("Game Over");
        }
    }
}