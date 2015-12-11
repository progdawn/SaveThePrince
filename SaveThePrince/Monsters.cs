using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrince
{
    //contains all monsters for the game. Kind of a "monster database." If I add more in the future, 
    //I'll probably create classes for different type of monsters, like "woodlands," "desert," etc.
    class Monsters
    {
        public Monsters()
        {

        }

        Random getMonster = new Random(Guid.NewGuid().GetHashCode()); //used to pick a random monster

        private const int totalMonsters = 8; //this isn't used, but I update it to keep track of total monsters in the game

        //five arrays with ascii art for monsters. I chose to do it this way so that I could pass in my "random monster" number,
        //and grab the namn, five ascii lines, hp, and ap, for the chosen monster. It worked very well. 
        private string[] monsterNames = { "Spooky Skeleton", "Cute Kitty", "Possessed Paper Bag", "Surprisingly Attractive Goblin", "ANTS", "Bat", "Ghost", "Tarantula" };
        private string[] monsterAscii = {  @"   _____    ", @" |\___/| ", @"  _______    ", @"   SSSSS    ", @" >OOO<   ", @"|\      /|", @"  _____   ", @"/\_____/\"};
        private string[] monsterAscii2 = { @"/\/     \/\ ", @" |     | ", @"~/\  o o \   ", @"  S     S   ", @"   >OOO< ", @"| \|\/|/ |", @" ( O O )  ", @"/\  8  /\" };
        private string[] monsterAscii3 = { @"> | X X | < ", @" | o o | ", @" \ \  ___ \  ", @"<S  ~ O  S> ", @"         ", @"||/(__)\||", @"  ) O  )  ", @"/\ o o /\" };
        private string[] monsterAscii4 = { @"\/| _I_ |\/ ", @">O  v  O<", @"~ \ \ \==\ \ ", @" |   U   |  ", @">OOO<    ", @"|/      \|", @"  (   (   ", @"/\OOOOO/\" };
        private string[] monsterAscii5 = { @"   \___/    ", @"  \___/  ", @"   \_\______\", @"  \_____/   ", @"    >OOO<", @"          ", @"   \  /   ", @"  ^ ^ ^  " };
        private int[] monsterHp = { 100, 30, 5, 75, 30, 80, 100, 50 }; //the monster's max HP
        private int[] monsterAp = { 25, 5, 0, 30, 40, 30, 20, 45 }; //the monster's max AP
        private int chosenMonster = 1; //the random monster chosen

        //picks a monster at random from the arrays. 
        //Since they run in parallel, I only need to do this for one array, any of them technically
        public void SelectMonster()
        {
            chosenMonster = getMonster.Next(0, monsterNames.Length);
        }

        public string[] MonsterNames
        {
            get { return monsterNames; }
            set { monsterNames = value; }
        }

        public string[] MonsterAscii
        {
            get { return monsterAscii; }
            set { monsterAscii = value; }
        }

        public string[] MonsterAscii2
        {
            get { return monsterAscii2; }
            set { monsterAscii2 = value; }
        }

        public string[] MonsterAscii3
        {
            get { return monsterAscii3; }
            set { monsterAscii3 = value; }
        }

        public string[] MonsterAscii4
        {
            get { return monsterAscii4; }
            set { monsterAscii4 = value; }
        }

        public string[] MonsterAscii5
        {
            get { return monsterAscii5; }
            set { monsterAscii5 = value; }
        }

        public int[] MonsterHp
        {
            get { return monsterHp; }
            set { monsterHp = value; }
        }

        public int[] MonsterAp
        {
            get { return monsterAp; }
            set { monsterAp = value; }
        }

        public int ChosenMonster
        {
            get { return chosenMonster; }
            set { chosenMonster = value; }
        }
    }
}
