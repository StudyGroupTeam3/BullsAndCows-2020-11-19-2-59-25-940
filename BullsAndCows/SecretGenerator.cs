using System;
using System.Collections.Generic;
using System.Linq;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            Random random = new Random();
            List<int> secret = new List<int>();
            secret.Add(random.Next(0, 10));
            for (var i = 1; i < 4; i++)
            {
                int tempRandomDigital = random.Next(0, 10);
                while (secret.Contains(tempRandomDigital))
                {
                    tempRandomDigital += random.Next(0, 10) - 10;
                }

                secret.Add(tempRandomDigital);
            }

            return string.Join(string.Empty, secret);
        }
    }
}