using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        Player player1;
        Player player2;
        public int pointsNeededToWin;

        public Game()
        {
            pointsNeededToWin = 2;
            player1 = new Human();
            
        }
        public void RunGame()
        {
            DisplayRules();
            ChooseGameType();

            player1.ChooseGesture();
            player2.ChooseGesture();
            CompareGesture();

            //DisplayWinner();
            
        }
        

        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules for the Game 'Rock, Paper, Scissors, Lizard, Spock.'");
            Console.WriteLine("Each round, select a gesture option to play against your opponent.");
            Console.WriteLine("Here are your gesture options and what each gesture does.");
            Console.WriteLine("1. Rock (crushes scissors and crushes lizard)");
            Console.WriteLine("2. Scissors (cuts paper and decapitates lizard)");
            Console.WriteLine("3. Paper (covers rock and disproves spock)");
            Console.WriteLine("4. Spock (smashes scissors and vaporizes rock");
            Console.WriteLine("The rounds will be best of 3 to decide winner");
            


        }
        public void ChooseGameType()
        {
            Console.WriteLine("Please select 'single player' or 'double player' to begin playing.");
            
            string userInput = Console.ReadLine();

            if (userInput == "single player")
            {
                //human vs computer
                player2 = new Computer();
            }
            else if (userInput == "double player")
            {
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("Try again.  Please type 'single player' or 'double player' to begin playing.");
                ChooseGameType();
            }

         

        }


        public void CompareGesture()
        {
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("It was a tie");
            }
            else if (player1.choice == "rock" && (player2.choice == "scissors" || player2.choice == "lizard"))
            {
                Console.WriteLine(player1.name + " won the round");
                player1.score++;
            }

        }



    }


}
