using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrince
{
    //lets the user change background and text colors
    class OptionsMenu
    {
        public OptionsMenu()
        {

        }

        private int optionChoice = 1;
        private int bgColorChoice = 1;
        private int textColorChoice = 1;

        //prints available options
        public void ViewAllOptions()
        {
            Console.WriteLine("Please choose an option (1, 2, 3)");
            Console.WriteLine("\t1) Change background color");
            Console.WriteLine("\t2) Change text color");
            Console.WriteLine("\t3) Return");
            Console.Write(">> ");
            optionChoice = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        //picks one of these, based on the user's choice
        public void ChooseAnOption()
        {
            switch (optionChoice)
            {
                case 1:
                    ChangeBgColorOptions();
                    ChangeBgColor();
                    break;
                case 2:
                    ChangeTextColorOptions();
                    ChangeTextColor();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            Console.Clear();
        }

        //displays background color choices
        public void ChangeBgColorOptions()
        {
            ConsoleColor originalBg = Console.BackgroundColor; //saves original user settings
            ConsoleColor originalText = Console.ForegroundColor;

            Console.WriteLine("Select a background color (1, 2, 3)");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Blue; //changed background color as well, to make the new text color easy to read
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1) Yellow");

            Console.BackgroundColor = originalBg;
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2) Cyan");

            Console.BackgroundColor = originalBg;
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("3) Black");

            Console.ForegroundColor = originalText;
            Console.BackgroundColor = originalBg;
            Console.Write(">> ");
            bgColorChoice = int.Parse(Console.ReadLine());
        }

        //changes background color, depending on user's choice
        public void ChangeBgColor()
        {
            switch (bgColorChoice)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
            }
        }

        //displays options for text colors
        public void ChangeTextColorOptions()
        {
            ConsoleColor originalText = Console.ForegroundColor; //saves user settings for bg and text colors
            ConsoleColor originalBg = Console.BackgroundColor;

            Console.WriteLine("Select a text color (1, 2, 3)");
            Console.Write("\t");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1) Blue");

            Console.BackgroundColor = originalBg;
            Console.Write("\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2) Red");

            Console.BackgroundColor = originalBg;
            Console.Write("\t");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("3) White");

            Console.BackgroundColor = originalBg;
            Console.ForegroundColor = originalText;
            Console.Write(">> ");
            textColorChoice = int.Parse(Console.ReadLine());
        }

        //changes text color, depending on user's choice
        public void ChangeTextColor()
        {
            switch (textColorChoice)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
            }
        }

        public int OptionChoice
        {
            get { return optionChoice; }
            set { optionChoice = value; }
        }

        public int BgColorChoice
        {
            get { return bgColorChoice; }
            set { bgColorChoice = value; }
        }

        public int TextColorChoice
        {
            get { return textColorChoice; }
            set { textColorChoice = value; }
        }
    }
}
