using BullsAndCows;
using Xunit;
using Moq;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_create_BullsAndCowsGame()
        {
            var mockSecretGenerator = new Mock<SecretGenerator>();
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        [Fact]
        public void Should_return_0A0B_when_all_digit_and_position_wrong()
        {
            // given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns("1234");
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            // when
            string answer = game.Guess("5 6 7 8");
            // then
            Assert.Equal("0A0B", answer);
        }

        [Theory]
        [InlineData("1 2 3 4", "1234")]
        [InlineData("5 6 7 8", "5678")]
        public void Should_return_4A0B_when_all_digit_and_position_right(string guess, string secret)
        {
            // given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            // when
            string answer = game.Guess(guess);
            // then
            Assert.Equal("4A0B", answer);
        }

        [Theory]
        [InlineData("4 3 2 1", "1234")]
        [InlineData("4 3 1 2", "1234")]
        public void Should_return_0A4B_when_all_digit_right_and_all_position_wrong(string guess, string secret)
        {
            // given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            // when
            string answer = game.Guess(guess);
            // then
            Assert.Equal("0A4B", answer);
        }
    }
}
