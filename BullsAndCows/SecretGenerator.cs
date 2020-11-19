using System;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            string secret = string.Empty;
            Random randomNumber = new Random();
            int count = randomNumber.Next(0, 10);
            for (int i = 0; i < 4; i++)
            {
                secret += count.ToString();
            }

            return secret;
        }
    }
}