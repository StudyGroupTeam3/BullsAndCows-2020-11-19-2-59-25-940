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
            string input = "4321";
            var output = game.Guess(input);
            Console.WriteLine(output);
            //while (game.CanContinue)
            //{
            //    var input = Console.ReadLine();
            //    var output = game.Guess(input);
            //    Console.WriteLine(output);
            //}

            //string x = "1234";
            //string y = "4321";

            Console.WriteLine("Game Over");
        }
    }
}