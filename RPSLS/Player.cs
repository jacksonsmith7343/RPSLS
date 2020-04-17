using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player
    

    
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
        
        public abstract void ChooseGesture();

    }

  
}
