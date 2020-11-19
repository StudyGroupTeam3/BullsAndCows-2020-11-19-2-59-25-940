using BullsAndCows;
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
            var answer = game.Judge("1 2 3 4");

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

        public class TestSecreteGenerator : SecretGenerator
        {
            public override string GenerateSecret()
            {
                return "5 6 7 8";
            }
        }
    }
}
