using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    public class CdPlayer
    {
        public string description = "CD Player";
        public string status = "off";
        public string cd = "";
        public int currentTrack = 0;
        public string playStatus = "stopped";

        public void on()
        {
            status = "on";
        }

        public void off()
        {
            status = "off";
        }

        public void eject()
        {
            cd = "";
            currentTrack = 0;
            playStatus = "stopped";
        }

        public void pause()
        {
            playStatus = "paused";
        }

        public void play(string cd)
        {
            this.cd = cd;
            currentTrack = 0;
            playStatus = "playing";
        }

        public void play(int track)
        {
            if (cd != "")
            {
                currentTrack = track;
                playStatus = "playing";
            }
        }

        public void dislayStatus()
        {
            Console.WriteLine("The " + description + " is " + status + ". " + cd + " is " + playStatus + ".");
        }
    }
}
