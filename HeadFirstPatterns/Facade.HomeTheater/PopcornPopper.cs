using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    public class PopcornPopper
    {
        public string description = "Popcorn popper";
        public string status = "off";
        public string popStatus = "not popping";

        public void on()
        {
            status = "on";
        }

        public void off()
        {
            status = "off";
            popStatus= "not popping";
        }

        public void pop()
        {
            popStatus = "popping";
        }

        public void displayStatus()
        {
            Console.WriteLine("The " + description + " is " + status + ". It is " + popStatus + ".");
        }
    }
}
