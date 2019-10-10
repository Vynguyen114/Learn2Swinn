using SwinGameSDK;
namespace MyGame
{
static class GameLogic
{
    /// <summary>
    /// This file controls how the graphics window appears and disappears when the game 
    /// is started up or closed down.
    /// </summary>
    public static void Main()
    {
        // Opens a new Graphics Window
        SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

        // Load Resources
        GameResources.LoadResources();

        //Play the game's background music
        SwinGame.PlayMusic("Background");

        // Game Loop
        do
        {
            GameController.HandleUserInput();
            GameController.DrawScreen();
        }
        while (!SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting);

        //Stop the background music when the window is closed
        SwinGame.StopMusic();

        // Free Resources and Close Audio, to end the program.
        GameResources.FreeResources();
    }
}
}