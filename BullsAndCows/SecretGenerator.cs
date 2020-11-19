using System;
using System.Collections.Generic;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            List<string> sourceList = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random random = new Random();
            int index = random.Next(0, 9);
            string secret = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                secret += sourceList[index];
                sourceList.RemoveAt(index);
            }

            return secret;
        }
    }
}