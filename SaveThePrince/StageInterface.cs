using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SaveThePrince
{
    //this is the main menu of the game, the way that the user navigates the different screens of the game
    class StageInterface
    {
        public StageInterface()
        {

        }

        Admin windowSize = new Admin(); //used to get window size, for graphics
        Random randomEnvironment = new Random(Guid.NewGuid().GetHashCode()); //used to draw the environment randomly
        SoundEffects music = new SoundEffects(); //sweet tunes

        private int playerOption = 1; //player's choice for battle, sleep, etc

        //displays available options for the game
        public void ChoosePlayerOption()
        {
            DrawMountain(); //draws a mountain and sky
            DrawGround(); //draws some grass
            DrawBorder(); //draws menu border
            Console.WriteLine("Choose an option (1, 2, 3, 4, 5, 6)");
            //Sleep();
            Console.WriteLine("\t1) Go into the wild");
            //Sleep();
            Console.WriteLine("\t2) Sleep through the night");
            //Sleep();
            Console.WriteLine("\t3) View stats");
            //Sleep();
            Console.WriteLine("\t4) View options");
            //Sleep();
            Console.WriteLine("\t5) View instructions");
            //Sleep();
            Console.WriteLine("\t6) Exit the game");
            //Sleep();
            Console.Write(">> ");
            music.StageMusicp1(); //sweet beats for menu
            playerOption = int.Parse(Console.ReadLine());
            Sleep();
            Console.Clear();
        }

        public void Sleep()
        {
            Thread.Sleep(500);
        }

        //draws "grass"
        public void DrawGround()
        {
            ConsoleColor originalText = Console.ForegroundColor; //saves current text color
            ConsoleColor grass = ConsoleColor.Green; //used for randomly selecting colors on grass
            ConsoleColor rocks = ConsoleColor.DarkCyan; 

            int environmentChance = 1; //random characters representing the ground
            int colorChance = 1; //randomly color for the ground

            string[] ground = { ",", "/", "_", ".", "@", ";", ",", ",", ",", "#" }; //my "grass" hah

            Console.SetCursorPosition(0, 14); //sets cursor to position for drawing grass. 

            //runs the inner loop 8 times, to fill the row with characters. 
            //I'm unhappy with hard numbers here, and would rather use some variables with arithmetic
            for (int x = 0; x < 8; x++)
            {
                //prints a random character from the grass array 10 times, randomizing the color as well
                for (int y = 0; y < 10; y++)
                {
                    colorChance = randomEnvironment.Next(0, 2);
                    if (colorChance == 1)
                    {
                        Console.ForegroundColor = grass;
                    }
                    else
                    {
                        Console.ForegroundColor = rocks;
                    }
                    environmentChance = randomEnvironment.Next(0, 10);
                    Console.Write(ground[environmentChance]);
                }
            }
            Console.ForegroundColor = originalText; //restores the user's text color
            Console.WriteLine();
        }

        //draws border below grass
        public void DrawBorder()
        {
            Console.SetCursorPosition(0, 15);
            //fills row with asterisk. Varies depending on window size, established in Admin class
            for (int optionBorder = 0; optionBorder < windowSize.WindowWidth; optionBorder++)
            {
                Console.Write("*");
            }
        }

        public int PlayerOption
        {
            get { return playerOption; }
            set { playerOption = value; }
        }

        //draws a mountain at a random column point on the screen
        public void DrawMountain()
        {
            int mountainStart = 1; //random Y coordinator
            mountainStart = randomEnvironment.Next(10, 45); //picks a random Y coordinator between these rows
            Console.SetCursorPosition(mountainStart, 8);
            Console.WriteLine(@"((O)~");
            Console.SetCursorPosition(mountainStart, 9);
            Console.WriteLine(@"          /\");
            Console.SetCursorPosition(mountainStart, 10);
            Console.WriteLine(@"         /  \");
            Console.SetCursorPosition(mountainStart, 11);
            Console.WriteLine(@"        /    \");
            Console.SetCursorPosition(mountainStart, 12);
            Console.WriteLine(@"  O    /      \   O");
            Console.SetCursorPosition(mountainStart, 13);
            Console.WriteLine(@"  |   /        \  |");
        }
    }
}
