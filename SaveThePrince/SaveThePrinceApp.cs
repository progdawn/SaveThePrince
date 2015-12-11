using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrince
{
    class SaveThePrinceApp
    {
        static void Main(string[] args)
        {
            Admin wizardry = new Admin();
            MainController controller = new MainController();

            wizardry.ConsoleSetup(); //sets up console size
            wizardry.Intro(); //provides introduction to application
            controller.MainGame(); //main game for application
            wizardry.Goodbye(); //screen for shutting down application
        }
    }
}
