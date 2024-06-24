using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

[assembly: InternalsVisibleTo("RockPaperScissors.Tests")]

namespace Rock_Paper_Scissors
{
    public class RPSGame
    {

        public void GameFlow()
        {
            Console.WriteLine(" Wellcome to our RPS game where you can play with AI lets get started!!\n");
            Console.WriteLine(" please enter your name: ");
            string name = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($" This is round {i}");
                round(name);
            }
        }

        public int PlayerMoves(Player player) 
        {
            Console.WriteLine(" please choose a move : Rock , Paper , Scisseor :\n ");
            string move = Console.ReadLine();
            int playedMove = player.playersMove(move);
            return playedMove;
        }

        public int AiMove() 
        {
            Random rnd = new Random();
            int movee = rnd.Next(1, 4);
            return movee;
        }

        public int roundWinner(int playerMove, int aiMove) //tested
        {
            if (playerMove == aiMove)
                return 0;
            if ((playerMove == 2 && aiMove == 1) || (playerMove == 1 && aiMove == 3) || (playerMove == 3 && aiMove == 2))
                return 1;

            return -1;


        }

        public string Answer(int ans) //tested 
        {
            string answer = "";
            if (ans == 1)
                answer = "Rock";
            else if (ans == 2)
                answer = "Paper";
            else if (ans == 3)
                answer = "Scisseor";
            return answer;
        }

        public void round(string name)
        {
            Player player = new Player();
            int n = 0;
            player.Name = name;
            int aiScore = 0;
            while (n != 3)
            {
                int ans = PlayerMoves(player);
                if (ans == -1)
                {
                    Console.WriteLine("your entered move is invalid! please try again and make sure your move is either Rock , Paper , Scisseor\n\n");
                    return;
                }
                int ai = AiMove();
                int winner = roundWinner(ans, ai);
                if (winner == 1)
                    player.Score++;
                else if (winner == -1)
                    aiScore++;
                else
                {
                    aiScore++;
                    player.Score++;
                }
                string Panswer = Answer(ans);
                string Aanswer = Answer(ai);
                Console.WriteLine($" {name} move : {Panswer} \n AI move : {Aanswer} \n\n your socre now : {player.Score} \n AI socre : {aiScore}\n ");
                n++;
            }
            int finalWinner = winner(player.Score, aiScore);
            if (finalWinner == 1)
                Console.WriteLine("Congrats! you won :)\n\n");
            else if (finalWinner == -1)
                Console.WriteLine("AI won on you! but dont worry you can always play again\n\n");
            else
                Console.WriteLine("this round is Draw no  one won!\n\n");

        }

        public int winner(int playerScore, int aiScore) //tested
        {
            if (playerScore > aiScore)
                return 1;
            else if (playerScore < aiScore)
                return -1;
            else
                return 0;

        }

    }
}