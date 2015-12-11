using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SaveThePrince
{
    //display and logic for sleeping through the night, restoring all hitpoints
    class PlayerSleep
    {
        public PlayerSleep()
        {

        }

        //passes in current/max hp, and returns difference, restoring player to max health
        public int Nightnight(int currentHp, int maxHp)
        {
            int hpRestored = maxHp - currentHp; //get HP difference

            //some cutesy sleeping animation
            for(int y = 35; y < 38; y ++)
            {
                Console.SetCursorPosition(y, 13);
                Console.Write("z");
                Thread.Sleep(500);
                Console.Write(" ");
            }

            Console.SetCursorPosition(0, 15);
            Console.WriteLine("\tYou sleep peacefully through the night.");
            Console.WriteLine("\tYou restore {0} hitpoints.", hpRestored);
            Console.Write("\tPress any key to return >> ");
            Twinkle(); //pretty blue star twinkle
            Console.ReadKey();
            Console.Clear();
            return hpRestored; //returns back to player in MainController
        }

        //twinkles some blue stars
        public void Twinkle()
        {
            ConsoleColor originalText = Console.ForegroundColor; //saves current text color
            Random littleStar = new Random(Guid.NewGuid().GetHashCode()); //for randomizing the stars

            //while the user has not pressed a key, twinkle some stars
            while (!Console.KeyAvailable)
            {
                int starPositionY = littleStar.Next(20, 60); //picks a random column between these two values
                int starPositionX = littleStar.Next(1, 7); //picks a random row between these two values

                Console.ForegroundColor = ConsoleColor.Blue; //sets star color
                Console.SetCursorPosition(starPositionY, starPositionX); //puts cursor in position to write star
                int left = Console.CursorLeft; //saves that position to overwrite later with a space, makin the star twinkle
                int top = Console.CursorTop;
                Console.Write("*");
                Thread.Sleep(200);
                Console.ForegroundColor = originalText; //sets text color to original, so the star disappears
                Console.SetCursorPosition(left, top); //returns cursor to the star's position, to overwrite with a space
                Console.Write(" ");
                Thread.Sleep(200);
            }
        }
    }
}
