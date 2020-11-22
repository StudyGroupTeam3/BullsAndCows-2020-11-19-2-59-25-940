using System;
using System.Collections.Generic;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            var rand = new Random();
            var numbers = new List<int>();
            const int numberCount = 4;

            for (var i = 0; i < numberCount; i++)
            {
                int number;
                do
                {
                    number = rand.Next(10);
                }
                while (numbers.Contains(number));
                numbers.Add(number);
            }

            return $"{numbers[0]}{numbers[1]}{numbers[2]}{numbers[3]}";
        }
    }
}