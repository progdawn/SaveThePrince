using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrince
{
    //displays current and max HP, attack power, little ascii face, and flavor text
    class PlayerMenu
    {
        public PlayerMenu()
        {

        }

        //shows the player's stats
        public void ViewPlayerStats(string name, int currentHp, int maxHp, int attack)
        {
            characterProfile(); //ascii art
            Console.SetCursorPosition(13, 0); //sets cursor so that stats are printed alongside the ascii art
            Console.Write("\t{0}", name);
            Console.WriteLine("\t{0}/{1} hitpoints", currentHp, maxHp);
            Console.SetCursorPosition(13, 1);
            Console.WriteLine("\t\t{0} attack power", attack);
            Console.SetCursorPosition(13, 4);
            FlavorText(currentHp, maxHp); //passes the hp over to a method that prints a message depending on hp percentage
            Console.SetCursorPosition(13, 6);
            Console.Write("\tPress any key to return >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //so artsy
        public void characterProfile()
        {
            string[] face = {
                @"************",
                @"*          *",
                @"*  O    O  *",
                @"*          *",
                @"*  ______  *",
                @"*          *",
                @"************" 
                            };
                    

            //prints each element of the array on a new line
            for (int x = 0; x < 7; x++)
            {
                Console.WriteLine(face[x]);
            }
        }

        //calculates hp percentage, and prints flavor text depending on how weak the player is
        public void FlavorText(int currentHp, int maxHp)
        {
            double hpRatio = (Convert.ToDouble(currentHp) / maxHp);

            if (hpRatio < 0.10)
            {
                Console.WriteLine("\tYou're fading in and out of consciousness.");
            }

            else if (hpRatio < 0.30)
            {
                Console.WriteLine("\tYou're struggling to stand up.");
            }
            else if (hpRatio < 0.50)
            {
                Console.WriteLine("\tYour body is aching.");
            }
            else if (hpRatio < 0.90)
            {
                Console.WriteLine("\tYou're feeling pretty good.");
            }
            else
            {
                Console.WriteLine("\tYou're hungry for battle.");
            }
        }
    }
}
