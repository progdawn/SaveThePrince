using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrince
{
    //main controlling class. After the lesson today (12/2), I would love to go with my original design of a separate controller for battles
    // story, and stage. Too many objects in this one class, and the class is just a tad too long for my taste
    class MainController
    {
        public MainController()
        {

        }

        StageInterface stage = new StageInterface();
        Player userPlayer = new Player();
        Enemy currentEnemy = new Enemy();
        BattleInterface battleUi = new BattleInterface();
        StoryInterface storyText = new StoryInterface();
        PlayerSleep goodnight = new PlayerSleep();
        OptionsMenu options = new OptionsMenu();
        PlayerMenu playerView = new PlayerMenu();
        InstructionsMenu instructions = new InstructionsMenu();

        //main game, short and sweet
        public void MainGame()
        {
            userPlayer.PlayerName = storyText.GetPlayerName(); //get the user's name once
            storyText.SendForthHero(userPlayer.PlayerName); //transition to stage interface
            //while user is not dead, and they have not chosen to quit, do this
            do
            {
                stage.ChoosePlayerOption();
                PickAThing();
            }while (stage.PlayerOption != 6 && userPlayer.CurrentHp > 0);
        }

        //chooses an option depending on user input
        public void PickAThing()
        {
            switch (stage.PlayerOption)
            {
                case 1:
                    BattleLoop();
                    break;
                case 2:
                    PlayerSleep();
                    break;
                case 3:
                    ViewStats();
                    break;
                case 4:
                    ViewOptions();
                    break;
                case 5:
                    ViewInstructions();
                    break;
                case 6:
                    break;
                default:
                    break;
            }
        }

        //if user chose to sleep, do this
        //used math.min so that the user isn't restored more than their max health
        public void PlayerSleep()
        {
            userPlayer.CurrentHp = Math.Min(userPlayer.CurrentHp + goodnight.Nightnight(userPlayer.CurrentHp, userPlayer.MaxHp), userPlayer.MaxHp);
        }

        //if user chose to view stats
        public void ViewStats()
        {
            playerView.ViewPlayerStats(userPlayer.PlayerName, userPlayer.CurrentHp, userPlayer.MaxHp, userPlayer.AttackPower);
        }

        //if user chose to view options, do this
        public void ViewOptions()
        {
            options.ViewAllOptions();
            options.ChooseAnOption();
        }

        //if user chose to view instructions
        public void ViewInstructions()
        {
            instructions.ViewAllInstructions();
            instructions.PickAnInstruction();
        }

        //main battle loop (would love this whole thing to be in another class. I will try pass an object at some point to do this
        public void BattleLoop()
        {
            currentEnemy.GenerateMonster(); //grabs a random monster from the Monster class

            //while user and enemy are alive, and user has not ran away
            while (userPlayer.CurrentHp > 0 && currentEnemy.CurrentHp > 0 && userPlayer.PlayerMove != 2)
            {
                battleUi.TrackPlayer(userPlayer.PlayerName, userPlayer.CurrentHp, userPlayer.MaxHp); //update player tracker
                battleUi.TrackEnemy(currentEnemy.MonsterName, currentEnemy.CurrentHp, currentEnemy.MaxHp, currentEnemy.AttackPower); //update enemy tracker

                //print ascii art for monster
                battleUi.ShowMonster(currentEnemy.ThisMonsterAscii, currentEnemy.ThisMonsterAscii2, currentEnemy.ThisMonsterAscii3, currentEnemy.ThisMonsterAscii4, currentEnemy.ThisMonsterAscii5);
                userPlayer.CurrentAp = userPlayer.AttackPowerRange(); //randomize this turn's attack for player
                currentEnemy.CurrentAp = currentEnemy.AttackPowerRange(); //randomize this turn's attack for enemy

                //grab user's choice, currently only attack and run away
                userPlayer.PlayerMove = battleUi.GetPlayerMove();

                //if user chose to attack
                if (userPlayer.PlayerMove == 1)
                {
                    battleUi.PlayerAttacked(userPlayer.PlayerName, currentEnemy.MonsterName, userPlayer.CurrentAp); //update battle log
                    currentEnemy.CurrentHp -= userPlayer.CurrentAp; //remove randomized attack power from enemy's current HP

                    //if the enemy is still alive, do the same for it
                    if (currentEnemy.CurrentHp > 0)
                    {
                        battleUi.EnemyAttacked(userPlayer.PlayerName, currentEnemy.MonsterName, currentEnemy.CurrentAp);
                        userPlayer.CurrentHp -= currentEnemy.CurrentAp;
                    }

                    //if enemy is not alive, print a message and return to stage inteface
                    else
                    {
                        battleUi.YouWon();
                    }
                    
                    //if player is dead, print this and exit game
                    if (userPlayer.CurrentHp <= 0)
                    {
                        battleUi.YouDied();
                    }
                }

                //if player chose to run away instead of attack, do this
                else if (userPlayer.PlayerMove == 2)
                {
                    battleUi.RanAway(userPlayer.PlayerName);
                }
            }

            //resets player move, so they're not constantly running away from battles
            userPlayer.PlayerMove = 1;
        }
        
    }
}
