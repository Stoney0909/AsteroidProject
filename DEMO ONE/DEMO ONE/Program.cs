using System;

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


            //TO DO
            //uncomment the code DO NOT DELETE THIS
            //Form1 Form1 = new Form1();
            //Form1.ShowDialog();

            //if (Form1.startGame())
            //{
                using (var game = new Game1())
                game.Run();
            //}
           
               
           
        }
    }
#endif
}
