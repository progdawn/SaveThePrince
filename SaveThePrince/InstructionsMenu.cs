using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SaveThePrince
{
    //used to display instructions for the game
    class InstructionsMenu
    {
        public InstructionsMenu()
        {

        }

        private int instructionChoice = 1; //which instruction the player wants to view

        //main menu for choose instructions
        public void ViewAllInstructions()
        {
            Console.WriteLine("Please choose an option (1, 2, 3)");
            Console.WriteLine("\t1) How to battle");
            Console.WriteLine("\t2) How to restore health");
            Console.WriteLine("\t3) Return");
            Console.Write(">> ");
            instructionChoice = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        //switch statement for printing the appropriate instruction
        public void PickAnInstruction()
        {
            switch (instructionChoice)
            {
                case 1:
                    HowToBattle();
                    break;
                case 2:
                    HowToSleep();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        //explains battles
        public void HowToBattle()
        {
            Console.WriteLine("\tWhen you go into the wild, you can encounter many creatures.\n");
            Lazy();
            Console.WriteLine("\tSome of them are weak, but others are vicious.\n");
            Lazy();
            Console.WriteLine("\tBefore going into the wild, be sure to check your hitpoints, or HP.\n");
            Lazy();
            Console.WriteLine("\tOnce you've encountered an enemy, you can attack or run away.\n");
            Lazy();
            Console.WriteLine("\tKeep an eye on the enemy's attack power, or AP.\n");
            Lazy();
            Console.WriteLine("\tThe higher their AP, the more they can attack for. \n");
            Lazy();
            Console.WriteLine("\tIf the enemy looks strong, don't be scared to run away.\n");
            Lazy();
            Console.WriteLine("\tOtherwise, keep attacking the enemy until they run out of HP.\n");
            Lazy();
            Console.WriteLine("\tIf you run out of HP, the game is over. \n");
            Lazy();
            Console.Write("\n\tPress any key to return >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //explains how to restore hp
        public void HowToSleep()
        {
            Console.WriteLine("\tAs you battle creatures, your health points, or HP, will get low.\n");
            Lazy();
            Console.WriteLine("\tTo restore all of your HP, go to sleep between battles.\n");
            Lazy();
            Console.WriteLine("\tWhen you wake up, you will feel refreshed!\n");
            Lazy();
            Console.Write("\n\tPress any key to return >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //thread.sleep shortcut
        public void Lazy()
        {
            Thread.Sleep(700);
        }
    }
}
