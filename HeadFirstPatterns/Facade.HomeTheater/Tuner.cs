using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    public class Tuner
    {
        string description = "Tuner";
        string status = "off";
        double channel = 0.0;
        string mode = "";

        public void on()
        {
            status = "on";
        }

        public void off()
        {
            status = "off";
        }

        public void setAm()
        {
            mode = "am";
        }

        public void setFm()
        {
            mode = "fm";
        }

        public void setFrequency(double frequency)
        {
            channel = frequency;
        }

        public void displayStatus()
        {
            Console.WriteLine("The " + description + " is " + status + ", the channel is set to " + channel + mode + ".");
        }

    }
}
