using System;

namespace Frogger
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Frogger game = new Frogger())
            {
                game.Run();
            }
        }
    }
#endif
}

