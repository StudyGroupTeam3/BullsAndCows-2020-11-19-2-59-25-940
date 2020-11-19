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

            for (var i = 0; i < 6; i++)
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