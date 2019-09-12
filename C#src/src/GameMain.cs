using System;
using SwinGameSDK;
using static SwinGameSDK.SwinGame; // requires mcs version 4+, 
// using SwinGameSDK.SwinGame; // requires mcs version 4+, 

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
            OpenGraphicsWindow("GameMain", 800, 600);
            ShowSwinGameSplashScreen();

            // Load Resources
            GameResources.LoadResources();

            //Play the game's background music
            SwinGame.PlayMusic("Background");
            //Run the game loop
            while (false == WindowCloseRequested())
            {
                //Clear the screen and draw the framerate
                ClearScreen(Color.White);
                DrawFramerate(0,0);
               

                GameController.HandleUserInput();
                GameController.DrawScreen();

                //Fetch the next batch of UI interaction
                ProcessEvents();

                //Draw onto the screen
                RefreshScreen(60);
            }

            //Stop the background music when the window is closed
            SwinGame.StopMusic();

            // Free Resources and Close Audio, to end the program.
            GameResources.FreeResources();
        }
    }
}
