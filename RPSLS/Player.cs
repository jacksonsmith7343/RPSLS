using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player
    

    //member variables
    {
        public List<string> gestures;
        public string name;
        public string choice;
        public int score;

        public Player()
        {
            score = 0;
            gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
  
        }

        //member methods (Can do)
        //// One round of game ////
        // 3) Display gesture options to the players         [PLAYER]
        // 4) Player 1 chooses gesture                       [PLAYER]
        // 5) Player 2 chooses gesture                       [PLAYER]
        // 6) Compare gestures (assign a point to ROUND winner/check for tie!)      [GAME]
        public abstract void ChooseGesture();

      
    }

  
}
