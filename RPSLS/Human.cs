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
            choice = Console.ReadLine();

            

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
