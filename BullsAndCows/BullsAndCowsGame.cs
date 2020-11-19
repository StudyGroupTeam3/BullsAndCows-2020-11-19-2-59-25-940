using System;

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

        public bool CanContinue(string input)
        {
            return true;
        }

        public string Guess(string guess)
        {
            string guessWithoutSpace = guess.Replace(" ", string.Empty);
            return this.Compare(this.secret, guessWithoutSpace);
        }

        public string Compare(string secret, string guess)
        {
            int countRightPosition = 0;
            int countRightNumber = 0;
            for (int i = 0; i < guess.Length; i++)
            {
                if (secret.IndexOf(guess[i]) != -1)
                {
                    if (secret.IndexOf(guess[i]) == i) { countRightPosition++; }
                    else { countRightNumber++; }
                }
            }

            return $"{countRightPosition}A{countRightNumber}B";
        }
    }
}