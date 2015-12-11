using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrince
{
    //contains data for the player character
    class Player
    {
        public Player()
        {

        }

        private string playerName = "Dawn"; //name
        private int currentHp = 100; //current hp
        private int maxHp = 100; //the max hp they can hold
        private int attackPower = 25; //max attack power
        private int playerMove = 1; //player move for battles
        private int playerOption = 1; //player choice for the stage interface
        private int currentAp = 1; //attack power, fluctuating for each turn

        Random apRange = new Random(Guid.NewGuid().GetHashCode()); //prevents attack from being a static number

        //creates fluctuating attack power
        public int AttackPowerRange()
        {
            int apLower = attackPower / 2;
            int currentApGet = apRange.Next(apLower, attackPower);
            return currentApGet;
        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int CurrentHp
        {
            get { return currentHp; }
            set { currentHp = value; }
        }

        public int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }

        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }

        public int PlayerMove
        {
            get { return playerMove; }
            set { playerMove = value; }
        }

        public int PlayerOption
        {
            get { return playerOption; }
            set { playerOption = value; }
        }

        public int CurrentAp
        {
            get { return currentAp; }
            set { currentAp = value; }
        }
    }
}
