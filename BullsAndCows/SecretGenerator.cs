using System;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public string GenerateSecret()
        {
            Random rnd = new Random();
            int firstDigit = rnd.Next(0, 9);
            int secondDigit = rnd.Next(0, 9);
            while (firstDigit == secondDigit)
            {
                secondDigit = rnd.Next(0, 9);
            }

            int thirdDigit = rnd.Next(0, 9);
            while (firstDigit == thirdDigit || secondDigit == thirdDigit)
            {
                thirdDigit = rnd.Next(0, 9);
            }

            int fourthDigit = rnd.Next(0, 9);
            while (firstDigit == fourthDigit || secondDigit == fourthDigit || thirdDigit == fourthDigit)
            {
                thirdDigit = rnd.Next(0, 9);
            }

            string secret = $"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit}";

            return secret;
        }
    }
}