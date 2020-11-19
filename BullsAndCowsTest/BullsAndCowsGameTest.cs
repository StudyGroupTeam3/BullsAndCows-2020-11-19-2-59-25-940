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
            // var secretGenerator = new SecretGenerator();
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        /*
        [Fact]
        public void ShouldReturn0A0BGivenAllDigitAndWrongPosition()
        {
            // given
            // var secretGenerator = new SecretGenerator();
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            string answer = game.Guess("5 6 7 8");
            // then
            Assert.Equal("0A0B", answer);
        }

        [Fact]
        public void ShouldReturn4A0BGivenAllDigitAndRightPosition()
        {
            // given
            // var secretGenerator = new SecretGenerator();
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
        public void ShouldReturn0A4BGivenAllDigitCorrectAndAllPositionWrong(string guess)
        {
            // given
            // var secretGenerator = new SecretGenerator();
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            string answer = game.Guess(guess);
            // then
            Assert.Equal("0A4B", answer);
        }

        [Theory]
        [InlineData("1 2 3 4", "1234")]
        [InlineData("5 6 7 8", "5678")]
        public void ShouldReturn4A0BGivenAllDigitAndAllRightPosition(string guess, string secret)
        {
            // given
            // var secretGenerator = new SecretGenerator();
            // 利用mock的方法代替SecretGenerator
            //var mockSecretGenerator = new Mock<SecretGenerator>();
            var mockSecretGenerator = new Mock<TestSecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            // when
            string answer = game.Guess(guess);
            // then
            Assert.Equal("4A0B", answer);
        }
        */

        [Theory]
        [InlineData("1 2 3 4", "5678")]
        [InlineData("5 6 7 8", "1234")]
        public void ShouldReturn0A0BGivenDigitNotInSecret(string guess, string secret)
        {
            // given
            var mockSecretGenerator = new Mock<TestSecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            // when
            string answer = game.Guess(guess);
            // then
            Assert.Equal("0A0B", answer);
        }

        [Theory]
        [InlineData("1 2 3 4", "1234")]
        [InlineData("5 6 7 8", "5678")]
        public void ShouldReturn4A0BGivenAllRightDigitAndAllRightPosition(string guess, string secret)
        {
            // given
            var mockSecretGenerator = new Mock<TestSecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);

            // when
            string answer = game.Guess(guess);
            // then
            Assert.Equal("4A0B", answer);
        }

        //[Theory]
        //[InlineData("4 1 3 2", "1234")]
        //public void ShouldReturn1A3BGivenAllDigitAndOneRightPosition(string guess, string secret)
        //{
        //    // given
        //    var mockSecretGenerator = new Mock<TestSecretGenerator>();
        //    mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
        //    var game = new BullsAndCowsGame(mockSecretGenerator.Object);

        //    // when
        //    string answer = game.Guess(guess);
        //    // then
        //    Assert.Equal("1A3B", answer);
        //}
    }

    public class TestSecretGenerator : SecretGenerator
    {
        public override string GenerateSecret()
        {
            return "1234";
        }
    }
}
