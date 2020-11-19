using System;
using System.Linq;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secret = string.Empty;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = this.secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Judge(string guess)
        {
            var guessWithOutSpace = guess.Replace(" ", string.Empty);
            return this.Answer(this.secret, guessWithOutSpace);
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