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
            var secretGenerator = new TestSecreteGenerator();
            var game = new BullsAndCowsGame(secretGenerator);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        [Fact]
        public void Should_return_0A0B_when_all_digit_and_position_wrong()
        {
            //given
            var secretGenerator = new TestSecreteGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            //when
            var answer = game.Judge("5 6 7 8");

            //then
            Assert.Equal("0A0B", answer);
        }

        [Fact]
        public void Should_return_4A0B_when_all_digit_and_position_right()
        {
            //given
            var secretGenerator = new TestSecreteGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            //when
            var answer = game.Judge("1 2 3 4");

            //then
            Assert.Equal("4A0B", answer);
        }

        [Theory]
        [InlineData("4 3 2 1", "1234")]
        public void Should_return_0A4B_when_all_digit_right_and_position_wrong(string guess, string secret)
        {
            //given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            //when
            var answer = game.Judge(guess);

            //then
            Assert.Equal("0A4B", answer);
        }

        [Theory]
        [InlineData("2 3 5 6", "1234")]
        public void Should_return_0A2B_when_2_digit_right_and_all_position_wrong(string guess, string secret)
        {
            //given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            //when
            var answer = game.Judge(guess);

            //then
            Assert.Equal("0A2B", answer);
        }

        [Theory]
        [InlineData("1 3 4 6", "1234")]
        public void Should_return_1A2B_when_2_digit_right_and_1_position_wrong(string guess, string secret)
        {
            //given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            //when
            var answer = game.Judge(guess);

            //then
            Assert.Equal("1A2B", answer);
        }

        [Theory]
        [InlineData("1 3 4 2", "1234")]
        public void Should_return_1A3B_when_3_digit_right_and_1_position_wrong(string guess, string secret)
        {
            //given
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            //when
            var answer = game.Judge(guess);

            //then
            Assert.Equal("1A3B", answer);
        }

        public class TestSecreteGenerator : SecretGenerator
        {
        }
    }
}
