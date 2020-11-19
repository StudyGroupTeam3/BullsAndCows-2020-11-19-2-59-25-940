using System;
using System.Linq;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            return string.Empty;
            //    string randomInput = string.Empty;
            //    string secret = string.Empty;
            //    while (secret.Length < 4)
            //    {
            //        Random randomNumber = new Random();
            //        int count = randomNumber.Next(0, 10);
            //        randomInput += count.ToString();
            //        int l1 = randomInput.Length;
            //        int l2 = secret.Length;
            //        if (l1 - l2 != 0)
            //        {
            //            secret = randomInput.Distinct().Count().ToString();
            //            Console.WriteLine(secret);
            //        }

            //        secret = randomInput;

            //        //Console.WriteLine(secret);
            //    }

            //    return secret;
            //}
        }
    }
}