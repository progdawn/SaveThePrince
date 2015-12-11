using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SaveThePrince
{
    //this class handles the user input and output during battles
    class BattleInterface
    {
        public BattleInterface()
        {

        }

        Monsters monsterOutput = new Monsters();
        Admin windowSize = new Admin();
        SoundEffects music = new SoundEffects();

        //keeps track of player health and attack power. Updates with each loop
        public void TrackPlayer(string name, int hitpoints, int maxHp)
        {
            Console.Clear();
            ConsoleColor originalBg = Console.BackgroundColor; //saves user setting for background color
            ConsoleColor originalText = Console.ForegroundColor; //saves user setting for text color
            Console.SetCursorPosition(0, 11); //moves cursor to position for the player bar
            Console.ForegroundColor = ConsoleColor.DarkBlue; //sets text color for player tracker text
            Console.BackgroundColor = ConsoleColor.Yellow; //sets background color for player tracker
            Console.Write("{0}: {1}/{2} HP", name, hitpoints, maxHp); //displays player's name, current HP, and max HP
            int left = Console.CursorLeft; //saves current position of cursor after printing tracker. Used in FOR loop
            //fills rest of line with color
            for (int x = left; x < windowSize.WindowWidth; x++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = originalBg; //restores user background color
            Console.ForegroundColor = originalText; //restores user text color
        }

        //same thing as player tracker, but for the enemy
        public void TrackEnemy(string name, int hitpoints, int maxHp, int ap)
        {
            ConsoleColor originalBg = Console.BackgroundColor;
            ConsoleColor originalText = Console.ForegroundColor;

            Console.WriteLine();
            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("{0}: {1}/{2} HP, {3} MAX AP", name, hitpoints, maxHp, ap);
            int left = Console.CursorLeft;
            for (int x = left; x < windowSize.WindowWidth; x++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = originalBg;
            Console.ForegroundColor = originalText;
        }

        //takes in the current monster's 5 ascii arrays, and prints them. 
        public void ShowMonster(string art1, string art2, string art3, string art4, string art5)
        {
            Console.SetCursorPosition(36, 3);
            Console.Write(art1);
            Console.SetCursorPosition(36, 4);
            Console.Write(art2);
            Console.SetCursorPosition(36, 5);
            Console.Write(art3);
            Console.SetCursorPosition(36, 6);
            Console.Write(art4);
            Console.SetCursorPosition(36, 7);
            Console.Write(art5);
        }

        //gets the player's next move for the battle 
        public int GetPlayerMove()
        {
            int playerMove = 1;
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("\t1) Attack");
            Console.WriteLine("\t2) Run away");
            Console.Write(">> ");

            //honestly, I should have the rest of this, down to "SetCursorPosition", in its own method
            int left = Console.CursorLeft; //saves current column
            int top = Console.CursorTop; //saves current row
            Console.SetCursorPosition(0, 17);
            //creates a border with combat log below it
            for (int optionBorder = 0; optionBorder < windowSize.WindowWidth; optionBorder++)
            {
                Console.Write("_");
            }
            Console.Write("Combat log");
            Console.SetCursorPosition(left, top);

            music.BattleMusicp1(); //little battle tune. Yay Console.Beep
            playerMove = int.Parse(Console.ReadLine()); //gets player move
            return playerMove; //and returns it for use in battle loop
        }

        //used in combat log for player attacking
        public void PlayerAttacked(string playerName, string enemyName, int attack)
        {
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("\t{0} attacked {1}!", playerName, enemyName);
            Thread.Sleep(750);
            Console.WriteLine("\t{0} was hit for {1} HP!", enemyName, attack);
            Thread.Sleep(750);
        }

        //used in combat log for enemy attacking
        public void EnemyAttacked(string playerName, string enemyName, int attack)
        {
            Console.WriteLine("\t{0} attacked {1}!", enemyName, playerName);
            Thread.Sleep(750);
            Console.WriteLine("\t{0} was hit for {1} HP!", playerName, attack);
            Thread.Sleep(750);
        }

        //if user chose to run away from battle
        public void RanAway(string name)
        {
            Console.SetCursorPosition(0, 19);
            Console.Write("\t{0} ran away!", name);
            Thread.Sleep(1000);
            Console.Clear();
        }

        //if user won the battle
        public void YouWon()
        {
            Console.Write("\tYou defeated the bad guy!");
            Thread.Sleep(1000);
            Console.Clear();
        }

        //if user dropped to 0 HP
        public void YouDied()
        {
            Console.Write("\tYou've met a terrible fate, haven't you?");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
