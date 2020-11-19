using System;
using System.Linq;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly int digitNumber = 5;
        private readonly SecretGenerator secretGenerator;
        private readonly string secret = string.Empty;
        private readonly string errorInformation = "Wrong Input, input again";
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = this.secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string CheckInput(string guess)
        {
            var guessWithoutSpace = guess.Replace(" ", string.Empty);
            if (guessWithoutSpace.Length < 4)
            {
                return this.errorInformation;
            }

            var guessWithoutSpaceAndGet4Char = guessWithoutSpace.Substring(0, 4);
            if (guessWithoutSpaceAndGet4Char.Length != guessWithoutSpaceAndGet4Char.Distinct().Count())
            {
                return this.errorInformation;
            }

            return string.Empty;
        }

        public string Guess(string guess)
        {
            var guessWithoutSpace = guess.Replace(" ", string.Empty);
            return this.Compare(this.secret, guessWithoutSpace);
        }

        private int GetCount(string secret, string guess)
        {
            int count = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    count++;
                }
            }

            return count;
        }

        private string Compare(string secret, string guess)
        {
            string result = string.Empty;
            int count = GetCount(secret, guess);
            for (int number = 0; number < digitNumber; number++)
            {
                if (secret.Where(secretChar => guess.Contains(secretChar)).ToList().Count == number)
                {
                    result = $"{count.ToString()}A{(number - count).ToString()}B";
                }
            }

            return result;
        }
    }
}