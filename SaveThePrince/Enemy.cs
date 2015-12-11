using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrince
{
    //this is the current enemy, generated from Monster class
    class Enemy
    {
        public Enemy()
        {

        }

        Monsters thisMonster = new Monsters();
        Random apRange = new Random(Guid.NewGuid().GetHashCode()); //used so that the current attack isn't a static number

        private string thisMonsterName = "NOPE"; //current monster name
        private string thisMonsterAscii = "idk"; //current monster's ASCII art, line 1 - 5
        private string thisMonsterAscii2 = "idk";
        private string thisMonsterAscii3 = "idk";
        private string thisMonsterAscii4 = "idk";
        private string thisMonsterAscii5 = "idk";

        private int thisCurrentHp = 100; //current monster's HP
        private int thisMaxHp = 100; //their max HP
        private int thisAttackPower = 5; //their max attack power
        private int currentAp = 1; //and their attack power for the current turn

        public void GenerateMonster()
        {
            thisMonster.SelectMonster(); //grabs a monster from the array, using random
            thisMonsterName = thisMonster.MonsterNames[thisMonster.ChosenMonster]; //populates the current enemy's properties
            thisMonsterAscii = thisMonster.MonsterAscii[thisMonster.ChosenMonster]; //based on the "chosen" monster
            thisMonsterAscii2 = thisMonster.MonsterAscii2[thisMonster.ChosenMonster];
            thisMonsterAscii3 = thisMonster.MonsterAscii3[thisMonster.ChosenMonster];
            thisMonsterAscii4 = thisMonster.MonsterAscii4[thisMonster.ChosenMonster];
            thisMonsterAscii5 = thisMonster.MonsterAscii5[thisMonster.ChosenMonster];
            thisCurrentHp = thisMonster.MonsterHp[thisMonster.ChosenMonster];
            thisMaxHp = thisMonster.MonsterHp[thisMonster.ChosenMonster];
            thisAttackPower = thisMonster.MonsterAp[thisMonster.ChosenMonster];

        }

        //used to fluctuate attack power for each turn
        public int AttackPowerRange()
        {
            int apLower = thisAttackPower / 2;
            int currentApGet = apRange.Next(apLower, thisAttackPower);
            return currentApGet;
        }

        public string MonsterName
        {
            get { return thisMonsterName; }
            set { thisMonsterName = value; }
        }

        public int CurrentHp
        {
            get { return thisCurrentHp; }
            set { thisCurrentHp = value; }
        }

        public int MaxHp
        {
            get { return thisMaxHp; }
            set { thisMaxHp = value; }
        }

        public int AttackPower
        {
            get { return thisAttackPower; }
            set { thisAttackPower = value; }
        }

        public string ThisMonsterAscii
        {
            get { return thisMonsterAscii; }
            set { thisMonsterAscii = value; }
        }

        public int CurrentAp
        {
            get { return currentAp; }
            set { currentAp = value; }
        }

        public string ThisMonsterAscii2
        {
            get { return thisMonsterAscii2; }
            set { thisMonsterAscii2 = value; }
        }

        public string ThisMonsterAscii3
        {
            get { return thisMonsterAscii3; }
            set { thisMonsterAscii3 = value; }
        }

        public string ThisMonsterAscii4
        {
            get { return thisMonsterAscii4; }
            set { thisMonsterAscii4 = value; }
        }

        public string ThisMonsterAscii5
        {
            get { return thisMonsterAscii5; }
            set { thisMonsterAscii5 = value; }
        }
    }
}
