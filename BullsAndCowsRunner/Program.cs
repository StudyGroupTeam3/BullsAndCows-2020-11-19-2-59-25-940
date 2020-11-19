using System;
using System.Linq;
using BullsAndCows;

namespace BullsAndCowsRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SecretGenerator secretGenerator = new SecretGenerator();
            //BullsAndCowsGame game = new BullsAndCowsGame(secretGenerator);
            //while (game.CanContinue)
            //{
            //    var input = Console.ReadLine();
            //    var output = game.Guess(input);
            //    Console.WriteLine(output);
            //}

            string a = "1234";
            string b = "1423";
            var c = a.Where(secretChar => b.Contains(secretChar)).ToList();
            foreach (var i in c)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Game Over");
        }
    }
}