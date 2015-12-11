using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SaveThePrince
{
    //this was irritating. Plays some annoying music. I may find a way to let the user "mute" this in the Options
    class SoundEffects
    {
        public SoundEffects()
        {

        }

        //I might play with random notes sometime
        //Random getAnote = new Random(Guid.NewGuid().GetHashCode());
        //scale                   C4   D4   E4  F4    G4   A4   B4   C5
        //private int[] notes = { 261, 293, 329, 349, 392, 440, 493, 523 };

        //music that plays during battle, until user hits a key. I used multiple methods, instead of nested while loops, to make things 
        //a bit more organized.
        //had to split it up, because otherwise a 10 second long loop would play, before the user's input would show on the screen.
        public void BattleMusicp1()
        {
            while (!Console.KeyAvailable)
            {
                Console.Beep(440, 250);
                Console.Beep(440, 250);
                Console.Beep(440, 250);
                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(250);
                    Thread.Sleep(250);
                    Thread.Sleep(250);
                    BattleMusicp2();
                }

            }
        }
         
        //second part of battle music loop
        public void BattleMusicp2()
        {
            while (!Console.KeyAvailable)
            {
                Console.Beep(349, 250);
                Console.Beep(349, 250);
                Console.Beep(349, 250);
                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(250);
                    Thread.Sleep(250);
                    Thread.Sleep(250);
                    BattleMusicp3();
                }
            }
        }

        //third part of battle music loop
        public void BattleMusicp3()
        {
            while (!Console.KeyAvailable)
            {
                Console.Beep(392, 250);
                Console.Beep(392, 250);
                Console.Beep(392, 250);
                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(250);
                    Thread.Sleep(250);
                    Thread.Sleep(250);
                    BattleMusicp4();
                }
            }
        }

        //fourth part of battle music loop
        public void BattleMusicp4()
        {
            while (!Console.KeyAvailable)
            {
                Console.Beep(329, 250);
                Console.Beep(329, 250);
                Console.Beep(329, 250);
                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(250);
                    Thread.Sleep(250);
                    Thread.Sleep(250);
                    BattleMusicp1(); //goes back to the original one, starting the music over
                }
            }
        }

        //music for the stage interface. Tried a different approach here, for more responsive user feedback. Still not happy with it.
        public void StageMusicp1()
        {
            while (!Console.KeyAvailable)
            {
                Console.Beep(261, 750);
                while (!Console.KeyAvailable)
                {
                    Console.Beep(293, 750);
                    while (!Console.KeyAvailable)
                    {
                        Console.Beep(392, 750);
                        while (!Console.KeyAvailable)
                        {
                            Console.Beep(329, 750);
                            StageMusicp2();
                        }
                    }
                }
            }
        }

        //part 2 of stage interface music
        public void StageMusicp2()
        {
            while (!Console.KeyAvailable)
            {
                Console.Beep(493, 750);
                while (!Console.KeyAvailable)
                {
                    Console.Beep(392, 750);
                    while (!Console.KeyAvailable)
                    {
                        Console.Beep(329, 1350);
                        StageMusicp1();
                    }
                }
            }
        }
    }
}
