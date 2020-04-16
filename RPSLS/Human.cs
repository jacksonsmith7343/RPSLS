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
            foreach (string gestures in gestures)
            {
                Console.WriteLine(gestures);
            }

            string userInput = Console.ReadLine();

            
           Console.WriteLine("Select one of the gesture options.");
            choice = Console.ReadLine();
        }
        public void SetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }

    }
}
