using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer : Player
        
    {
        //member variables (Has A)



        //Constructor (Spawner)
        public Computer()
        {
            name = "computer";
        }


        //member methods (Can do)
        public override void ChooseGesture()
        {
            // generate a random number
            //use that number to grab a value out of the list of geatures by using that randomly generated number as an index
            Random rnd = new Random();

            int i = rnd.Next(0, 4);

            choice = gestures[i];
        }


        //Play a game with a human
        //generate a random gesture

    }
}
