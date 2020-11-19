using BullsAndCows;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_create_BullsAndCowsGame()
        {
            var testSecretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(testSecretGenerator);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        [Fact]
        public void Should_return_0A0B_when_all_digit_and_position_wrong()
        {
            // given
            var testSecretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(testSecretGenerator);
            // when
            string answer = game.Guess("5678");
            // then
            Assert.Equal("0A0B", answer);
        }

        public class TestSecretGenerator : SecretGenerator
        {
            public override string GenerateSecret()
            {
                return "1234";
            }
        }
    }
}
