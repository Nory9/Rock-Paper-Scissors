using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Player
    {
        private string _name;
        private int _score;

        public string Name { 
            get { return _name; }
            set { _name = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        
        }

        public int playersMove(string move) {
          //  string move = "";
          //  Console.WriteLine("please choose a move : Rock , Paper , Scisseor");
            //move = Console.ReadLine();
            string checked_move= validation(move);
            if (checked_move != "")
            {
                if (checked_move == "rock")
                    return 1;
                else if (checked_move == "paper")
                    return 2;
                else
                    return 3;
            }
            else {
              
                return -1;
            }
        }

        public string validation(string move) { 
         if(move.ToLower()=="rock"||move.ToLower()=="paper"||move.ToLower()== "scisseor")
                return move.ToLower();
         else 
                return "";

        }
    }
}
