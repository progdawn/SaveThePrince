using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SaveThePrince
{
    //basic story text for the game
    class StoryInterface
    {
        public StoryInterface()
        {

        }

        //gets the player's name
        public string GetPlayerName()
        {
            string playerName = "Dawn";

            Console.WriteLine("\tOh great hero, savior of our people!\n");
            Sleep();
            Console.WriteLine("\tCrusher of skulls, looter of corpses, kicker of buns!\n");
            Sleep();
            Console.WriteLine("\tWhat is your name?");
            Console.Write("\n\t>> ");
            playerName = Console.ReadLine();
            Sleep();
            Console.Clear();
            return playerName;
        }

        //transitions to stage interface
        public void SendForthHero(string playerName)
        {
            Console.WriteLine("\t{0}, go forth to The Land of Totally Bad People, and save our Prince.\n", playerName);
            Sleep();
            Console.WriteLine("\tYou're sure to encounter spooky skeletons,\n");
            Sleep();
            Console.WriteLine("\t\tcrazed bandits,\n");
            Sleep();
            Console.WriteLine("\trabid rabbits,\n");
            Sleep();
            Console.WriteLine("\t\tand many more horrors.\n");
            Sleep();
            Console.WriteLine("\tWe know you will be victorious. May your blade never dull, lass!\n");
            Sleep();
            Console.Write("\tPress any key to begin >> ");
            Console.ReadKey();
            Console.Clear();
        }

        public void Sleep()
        {
            Thread.Sleep(500);
        }
    }
}
