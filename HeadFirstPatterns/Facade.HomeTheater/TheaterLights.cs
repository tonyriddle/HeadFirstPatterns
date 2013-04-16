using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    public class TheaterLights
    {
        string description = "Theater lights";
        string status = "off";
        int brightness = 0;

        public void on()
        {
            status = "on";
            brightness = 10;
        }

        public void off()
        {
            status = "off";
            brightness = 0;
        }

        public void dim()
        {
            if (brightness < 10)
            {
                brightness = brightness - 1;
            }
            else
            {
                brightness = 10;
            }

        }

        public void displayStatus()
        {
            Console.WriteLine("The " + description + " are " + status + ". The brightness is set to " + brightness.ToString() + ".");
        }
    }
}
