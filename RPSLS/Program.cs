using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.RunGame();

            
            // 1) Display rules (also include how many rounds!)  [GAME]
            // 2) What are we playing? (HvH or HvC?)             [GAME]

            //// One round of game ////
            // 3) Display gesture options to the players         [PLAYER]
            // 4) Player 1 chooses gesture                       [PLAYER]
            // 5) Player 2 chooses gesture                       [PLAYER]
            // 6) Compare gestures (assign a point to ROUND winner/check for tie!)      [GAME]
            // 7) Display current score                          [GAME]
            // 8) Check for GAME winner (best of 3/5)            [GAME]

            // if no
            // 9a) Repeat steps 3-8
            // if yes
            // 9b) Display final results                     [GAME]

            // 10) Ask to play again?                            [GAME]

        }
    }
}
