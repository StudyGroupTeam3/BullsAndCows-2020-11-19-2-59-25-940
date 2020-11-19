using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;

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
            GameMaxCount = 6;
            CanContinue = 0;
        }

        public int CanContinue { get; set; }

        public int GameMaxCount { get; set; }

        public string Guess(string guess)
        {
            var guessWithoutSpace = guess.Replace(" ", string.Empty);
            return this.Compare(this.secret, guessWithoutSpace);
        }

        private string Compare(string secret, string guess)
        {
            var count = secret.Where(guess.Contains).Count();
            var correctPosition = secret.Where((i, index) => i == guess[index]).Count();

            return $"{correctPosition}A{count - correctPosition}B";
        }
    }
}