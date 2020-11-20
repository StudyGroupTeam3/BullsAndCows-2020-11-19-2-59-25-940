using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secret = string.Empty;
        private int gameCount;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = this.secretGenerator.GenerateSecret();
            gameCount = 1;
        }

        public bool CanContinue()
        {
            return gameCount < 6 ? true : false;
        }

        public string Judge(string guess)
        {
            var guessWithOutSpace = guess.Replace(" ", string.Empty);
            gameCount += 1;
            return this.Answer(this.secret, guessWithOutSpace);
        }

        public bool IsInputValid(string guess)
        {
            var rules = new Regex(@"^([0-9]\s){3}[0-9]$");
            if (rules.IsMatch(guess))
            {
                return guess.Split(" ").Distinct().ToArray().Length == 4 ? true : false;
            }
            else
            {
                return false;
            }
        }

        private string Answer(string secret, string guess)
        {
            int bulls = 0;
            int cows = 0;
            for (int index = 0; index < secret.Length; index++)
            {
                if (guess.Contains(secret[index]))
                {
                    if (guess.IndexOf(secret[index]) == index)
                    {
                        bulls += 1;
                    }
                    else
                    {
                        cows += 1;
                    }
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}