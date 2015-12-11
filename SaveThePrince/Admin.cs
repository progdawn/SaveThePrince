using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SaveThePrince
{
    //used for setting up the console, providing introduction, and exiting the application
    class Admin
    {
        //default constructor
        public Admin()
        {

        }

        //I set these as properties, so that other classes could access this. The console size is used for "graphics"
        private int windowWidth = 80;
        private int windowHeight = 25;

        //sets up console title, size, and colors
        public void ConsoleSetup()
        {
            Console.Title = "Save The Prince!"; //window title
            Console.SetWindowSize(windowWidth, windowHeight); //window size, makes things easier to read
            Console.BackgroundColor = ConsoleColor.Black; //background color of console
            Console.ForegroundColor = ConsoleColor.White; //text color
            Console.Clear();
        }

        //introduction and instructions for the application
        public void Intro()
        {
            Console.Beep(330, 500);
            Console.WriteLine("\tGreetings, adventurer!\n");
            Lazy();
            Console.WriteLine("\tThe prince of Generic Kingdom has been kidnapped by THE BAD GUY.\n");
            Lazy();
            Console.WriteLine("\tHe's been taken far away to The Land of Totally Bad People.\n");
            Lazy();
            Console.WriteLine("\tPlease save him, hero. You're our only hope!\n");
            Lazy();
            Console.Write("\tPress any key to begin your adventure >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //provides a way to exit the application
        public void Goodbye()
        {
            Console.Beep(330, 200);
            Console.WriteLine("Thanks for playing!");
            Lazy();
            Console.Write("Shutting down");
            Lazy();
            Console.Write(".");
            Lazy();
            Console.Write(".");
            Lazy();
            Console.Write(".");
        }

        //shortcute for thread.sleep
        public void Lazy()
        {
            Thread.Sleep(500);
        }

        public int WindowWidth
        {
            get { return windowWidth; }
            set { windowWidth = value; }
        }

        public int WindowHeight
        {
            get { return windowHeight; }
            set { windowHeight = value; }
        }
    }
}
