using System;
using System.Collections.Generic;
using System.Text;

namespace BullsAndCowsRunner
{
    public class UserGuessValidator
    {
        public bool Validate(string guess)
        {
            string guessWithoutSpace = guess.Replace(" ", string.Empty);
            if (guessWithoutSpace.Length != 4)
            {
                return false;
            }

            return true;
        }
    }
}
