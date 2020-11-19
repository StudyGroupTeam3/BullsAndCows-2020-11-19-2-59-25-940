using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using BullsAndCowsRunner;

namespace BullsAndCowsTest
{
    public class UserGuessValidatorTest
    {
        [Theory]
        [InlineData("1 2 3 4")]
        public void Should_return_true_when_user_guess_4_digitals_seperated_with_space(string userGuess)
        {
            // given
            UserGuessValidator userGuessValidator = new UserGuessValidator();
            // when
            bool validateResult = userGuessValidator.Validate(userGuess);
            // then
            Assert.True(validateResult);
        }

        [Theory]
        [InlineData("1 2 3 4 5")]
        [InlineData("1 2 3")]
        [InlineData("")]
        public void Should_return_false_when_number_of_user_guess_is_not_4(string userGuess)
        {
            // given
            UserGuessValidator userGuessValidator = new UserGuessValidator();
            // when
            bool validateResult = userGuessValidator.Validate(userGuess);
            // then
            Assert.False(validateResult);
        }

        [Theory]
        [InlineData("1 2 a 4")]
        public void Should_return_false_when_not_all_user_guess_is_digital(string userGuess)
        {
            // given
            UserGuessValidator userGuessValidator = new UserGuessValidator();
            // when
            bool validateResult = userGuessValidator.Validate(userGuess);
            // then
            Assert.False(validateResult);
        }
    }
}
