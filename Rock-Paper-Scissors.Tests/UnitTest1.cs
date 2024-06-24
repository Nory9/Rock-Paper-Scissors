using Xunit;
using Rock_Paper_Scissors;

namespace Rock_Paper_Scissors.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AnswerTest_pass()
        {
            //Arrange
            var game = new RPSGame();
            int input = 1;

            // Act 
            string result = game.Answer(input);

            // Assert
            Assert.Equal("Rock", result);
        }

        [Fact]
        public void roundWinner_playerWins()
        {
            var game = new RPSGame();
           
            // Act 
            int result = game.roundWinner(1,3);

            // Assert
            Assert.Equal(1, result);
        }


        [Fact]
        public void roundWinner_aiWins()
        {
            var game = new RPSGame();

            // Act 
            int result = game.roundWinner(1, 2);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void roundWinner_draw()
        {
            var game = new RPSGame();

            // Act 
            int result = game.roundWinner(1, 1);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void winner_userWins() { 

        var game= new RPSGame();

            //act 
            int result = game.winner(2, 1);

            Assert.Equal(1, result);
        }
        [Fact]
        public void winner_aiWins()
        {

            var game = new RPSGame();

            //act 
            int result = game.winner(0, 1);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void winner_draw()
        {

            var game = new RPSGame();

            //act 
            int result = game.winner(2, 2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void playersMove() {

            string input = "rock";
            var player=new Player();

            int result =player.playersMove(input);

            Assert.Equal(1, result);

        }
        [Fact]
        public void playersMove_invalidInput()
        {
            string input = "anything";
            var player = new Player();

            int result = player.playersMove(input);

            Assert.Equal(-1, result);

        }

        [Fact]
        public void validation_passed()
        {
            string input = "PAPER";
            var player = new Player();

            string result =player.validation(input);

            Assert.Equal("paper", result);

        }

        [Fact]
        public void validation_failed()
        {
            string input = "anythinggg";
            var player = new Player();

            string result = player.validation(input);

            Assert.Equal("", result);

        }

    }
}