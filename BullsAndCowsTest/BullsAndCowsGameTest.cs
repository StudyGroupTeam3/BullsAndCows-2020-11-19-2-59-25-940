using BullsAndCows;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_create_BullsAndCowsGame()
        {
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        [Fact]
        public void Should_return_0A0B_when_all_digit_position_Right()
        {
            // given
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            string answer = game.Guess("1 2 3 4");

            // then
            Assert.Equal("4A0B", answer);
        }

        [Theory]
        [InlineData("4 3 2 1")]
        [InlineData("3 4 2 1")]
        public void Should_return_0A4B_when_all_digit_Wrong(string guess)
        {
            // given
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            string answer = game.Guess(guess);

            // then
            Assert.Equal("0A4B", answer);
        }

        [Theory]
        [InlineData("5 6 7 8")]
        [InlineData("6 5 8 9")]
        public void Should_return_0A0B_when_all_digit_position_Wrong(string guess)
        {
            // given
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            string answer = game.Guess(guess);

            // then
            Assert.Equal("0A0B", answer);
        }
    }

    public class TestSecretGenerator : SecretGenerator
    {
        public override string GenerateSecret()
        {
            return "1234";
        }
    }
}
