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
            Assert.True(true);
        }

        [Fact]
        public void Should_return_0A0B_when_all_digit_and_position_wrong()
        {
            // given
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            var answer = game.Guess("5 6 7 8");

            // then
            Assert.Equal("0A0B", answer);
        }

        [Theory]
        [InlineData("1 2 3 4", "1234")]
        [InlineData("5 6 7 8", "5678")]
        [InlineData("4 2 7 8", "4278")]
        public void Should_return_4A0B_when_all_digit_and_position_right(string guess, string secret)
        {
            // given
            var fake = new Mock<SecretGenerator>();
            fake.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(fake.Object);

            // when
            var answer = game.Guess(guess);

            // then
            Assert.Equal("4A0B", answer);
        }

        [Theory]
        [InlineData("4 3 2 1")]
        [InlineData("4 3 1 2")]
        public void Should_return_0A4B_when_digit_wrong_and_position_right(string guess)
        {
            // given
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            var answer = game.Guess(guess);

            // then
            Assert.Equal("0A4B", answer);
        }

        [Theory]
        [InlineData("1 2 3 4", "1423")]
        [InlineData("5 6 7 8", "7685")]
        [InlineData("4 2 7 8", "8472")]
        public void Should_return_1A3B(string guess, string secret)
        {
            // given
            var fake = new Mock<SecretGenerator>();
            fake.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(fake.Object);

            // when
            var answer = game.Guess(guess);

            // then
            Assert.Equal("1A3B", answer);
        }

        [Theory]
        [InlineData("1 2 3 4", "1523")]
        [InlineData("5 6 7 8", "9685")]
        [InlineData("4 2 7 8", "8072")]
        public void Should_return_1A2B(string guess, string secret)
        {
            // given
            var fake = new Mock<SecretGenerator>();
            fake.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(fake.Object);

            // when
            var answer = game.Guess(guess);

            // then
            Assert.Equal("1A2B", answer);
        }

        [Theory]
        [InlineData("1 2 3 4", "9523")]
        [InlineData("5 6 7 8", "9185")]
        [InlineData("4 2 7 8", "8032")]
        public void Should_return_0A2B(string guess, string secret)
        {
            // given
            var fake = new Mock<SecretGenerator>();
            fake.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(fake.Object);

            // when
            var answer = game.Guess(guess);

            // then
            Assert.Equal("0A2B", answer);
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
