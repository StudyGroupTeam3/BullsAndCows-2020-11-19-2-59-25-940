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

        public string Guess(string guess)
        {
            var guessWithoutSpace = guess.Replace(" ", string.Empty);
            return this.Compare(this.secret, guessWithoutSpace);
        }

        private string Compare(string secret, string guess)
        {
            string result = string.Empty;

            if (secret.Where(secretChar => guess.Contains(secretChar)).ToList().Count == 0)
            {
                result = "0A0B";
            }

            if (secret.Where(secretChar => guess.Contains(secretChar)).ToList().Count == 4)
            {
                int count = 0;
                for (int i = 0; i < secret.Length; i++)
                {
                    if (secret[i] == guess[i])
                    {
                        count++;
                    }
                }

                if (count == 4)
                {
                    result = "4A0B";
                }

                if (count == 0)
                {
                    result = "0A4B";
                }

                if (count == 1)
                {
                    result = "1A3B";
                }
            }

            if (secret.Where(secretChar => guess.Contains(secretChar)).ToList().Count == 3)
            {
                int count = 0;
                for (int i = 0; i < secret.Length; i++)
                {
                    if (secret[i] == guess[i])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    return "1A2B";
                }
            }

            return result;
        }
    }
}