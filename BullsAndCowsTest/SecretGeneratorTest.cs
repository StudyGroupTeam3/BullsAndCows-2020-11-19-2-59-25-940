using System;
using System.Collections.Generic;
using System.Text;
using BullsAndCows;
using Xunit;

namespace BullsAndCowsTest
{
    public class SecretGeneratorTest
    {
        [Fact]
        public void Secret_length_should_be_4()
        {
            // given
            string secret = string.Empty;
            var secretGenerator = new SecretGenerator();

            // when
            secret = secretGenerator.GenerateSecret();

            // then
            Assert.Equal(4, secret.Length);
        }

        [Fact]
        public void Secret_should_different_between_two_generate()
        {
            string secret1;
            string secret2;
            SecretGenerator secretGenerator = new SecretGenerator();
            secret1 = secretGenerator.GenerateSecret();
            secret2 = secretGenerator.GenerateSecret();
            Assert.NotEqual(secret1, secret2);
        }
    }
}
