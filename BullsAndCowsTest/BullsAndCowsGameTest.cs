using BullsAndCows;
using Moq;
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

        [Theory]
        [InlineData("4 3 2 1", "4321")]
        [InlineData("3 4 2 1", "3421")]
        public void Should_return_4A0B_when_all_digit_position_Right(string guest, string secret)
        {
            // given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            // when
            string answer = game.Guess(guest);

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
        [InlineData("4 2 1 3", "4321")]
        [InlineData("3 2 1 4", "3421")]
        public void Should_return_1A3B_when_part_digit_right_all_position_Right(string guest, string secret)
        {
            // given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            // when
            string answer = game.Guess(guest);

            // then
            Assert.Equal("1A3B", answer);
        }

        [Theory]
        [InlineData("4 2 1 5", "4321")]
        [InlineData("3 2 1 5", "3421")]
        public void Should_return_1A2B_when_all_digit_position_Right(string guest, string secret)
        {
            // given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            // when
            string answer = game.Guess(guest);

            // then
            Assert.Equal("1A2B", answer);
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
