using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    public class Amplifier
    {
        public string description = "Amplifier";
        public string status = "on";
        public int volume = 0;

        public void on()
        {
            status = "on";
        }

        public void off()
        {
            status = "off";
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
        }

        public void displayStatus()
        {
            Console.WriteLine("The " + description + " is " + status + ". The Volume is set to " + volume.ToString() + ".");
        }
    }
}
