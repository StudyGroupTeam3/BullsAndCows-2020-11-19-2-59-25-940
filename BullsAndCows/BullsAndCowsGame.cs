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

        public bool CanContinue => true;

        public string Judge(string guess)
        {
            var guessWithOutSpace = guess.Replace(" ", string.Empty);
            return this.Answer(this.secret, guess);
        }

        private string Answer(string secret, string guess)
        {
            return "0A0B";
        }
    }
}