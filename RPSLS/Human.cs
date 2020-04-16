using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {
        //member variables (Has A)



        //Constructor (Spawner)
        public Human()
        {
            SetName();
        }


        //member methods (Can do)
        public override void ChooseGesture()
        {
            Console.WriteLine("Select one of the gesture options.");

            foreach (string gestures in gestures)
            {
                Console.WriteLine(gestures);
            }

            //choice = Console.ReadLine();

            //Console.WriteLine(gestures[1, 4]);

            //choice = gestures[0];





        }
        public void SetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }

        //play a game with a computer
        //play a game with another human
        //chose a gesture to play from a list
    }
}
