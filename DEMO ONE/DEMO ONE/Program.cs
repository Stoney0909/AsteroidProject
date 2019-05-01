using System;
using DEMO_ONe.Content.Players;
namespace DEMO_ONe
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool keepPlaying = true;
            while (keepPlaying)
            {
                //TO DO
                //uncomment the code DO NOT DELETE THIS

                Form1 Form1 = new Form1();
                Form1.ShowDialog();
                keepPlaying = Form1.keepPlaying;
                string name = Form1.name;

                if (Form1.startGame())
                {
                    using (var game = new Game1(name))
                    {
                        game.Run();
                        keepPlaying = game.keepPlaying;
                    }
                }
            }

        }
    }
#endif
}
