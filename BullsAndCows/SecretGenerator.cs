using System;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            Random random = new Random();
            int[] secret = new int[4];
            secret[0] = random.Next(0, 10);
            for (var i = 1; i < 4; i++)
            {
                int tempRandomDigital = random.Next(0, 10);
                while (tempRandomDigital == secret[i - 1])
                {
                    tempRandomDigital += random.Next(0, 10) - 10;
                }

                secret[i] = tempRandomDigital;
            }

            return string.Join(string.Empty, secret);
        }
    }
}