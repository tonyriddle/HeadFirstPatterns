using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    public class Projector
    {
        string description = "projector";
        string status = "off";
        string screenMode = "TV";

        public void on()
        {
            status = "on";
        }

        public void off()
        {
            status = "off";
        }

        public void tvMode()
        {
            screenMode = "TV";
        }

        public void wideScreenMode()
        {
            screenMode = "Wide Screen";
        }

        public void displaySatus()
        {
            Console.WriteLine("The " + description + " is " + status + ". The screen is set to " + screenMode + ".");
        }
    }
}
