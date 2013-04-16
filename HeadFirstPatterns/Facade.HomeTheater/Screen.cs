using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    public class Screen
    {
        public string description = "Screen";
        public string status = "up";

        public void up()
        {
            status = "up";
        }

        public void down()
        {
            status = "down";
        }

        public void displayStatus()
        {
            Console.WriteLine("The " + description + " is " + status + ".");
        }
    }

}
