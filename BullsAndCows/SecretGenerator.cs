using System;
using System.Collections.Generic;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            List<int> digits = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            };
            Random rnd = new Random();
            int firstDigit = digits[rnd.Next(0, 10)];
            digits.Remove(firstDigit);
            int secondDigit = digits[rnd.Next(0, 9)];
            digits.Remove(secondDigit);
            int thirdDigit = digits[rnd.Next(0, 8)];
            digits.Remove(thirdDigit);
            int fourthDigit = digits[rnd.Next(0, 7)];

            string secret = $"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit}";

            return secret;
        }
    }
}