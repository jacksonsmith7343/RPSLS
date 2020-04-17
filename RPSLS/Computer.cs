using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer : Player
        
    {
        
        public Computer()
        {
            name = "computer";
        }


        
        public override void ChooseGesture()
        {
          
            Random rnd = new Random();

            int i = rnd.Next(0, 4);

            choice = gestures[i];
        }


    }
}
