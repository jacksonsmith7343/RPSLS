using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {
        
        public Human()
        {
            SetName();
        }


        
        public override void ChooseGesture()
        {
            Console.WriteLine("Select one of the gesture options.");
            Console.WriteLine("rock  paper  scissor  lizard  spock");

            choice = Console.ReadLine();

         switch (choice)
            {
                case "rock":

                    break;
                case "paper":

                    break;
                case "scissors":

                    break;
                case "lizard":

                    break;
                case "spock":
                default:
                    Console.WriteLine("Not a valid gesture option. Select again.");
                    break;
            }
             
            
      



            

            
        }
        public void SetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }

    }
}
