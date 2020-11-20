using System;
using System.Collections.Generic;
using System.Linq;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            string randomInput = string.Empty;
            int count = 0;
            while (count < 30)
            {
                Random randomNumber = new Random();
                int number = randomNumber.Next(0, 10);
                randomInput += number.ToString();
                count++;
            }

            string secret = string.Join(string.Empty, randomInput.ToArray().Distinct()).Substring(0, 4);
            return secret;
        }
    }
}