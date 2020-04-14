using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Player
    //this class will have a list containing all of the gesture options

    //member variables
    {
        List<string> gestures;

        public Player()
        {
            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");

            Console.WriteLine(gestures);

          
        }

        //member methods (Can do)
        public void rockAttack()
        {

        }


        public void paperAttack()
    {


    }

        public void scissorsAttack()
    {


    }


        public void lizardAttack()
    {


    }


        public void spockAttack()
    {


    }




    }

  
}
