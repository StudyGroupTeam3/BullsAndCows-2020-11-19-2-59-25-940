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
            if (secret == guess)
            {
                return "4A0B";
            }

            if (secret.Where(secretChar => guess.Contains(secretChar)).ToList().Count == 4)
            {
                return "0A4B";
            }

            return "0A0B";
        }
    }
}