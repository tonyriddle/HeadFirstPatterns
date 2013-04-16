using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Facade.HomeTheater
{
    public class DvdPlayer
    {
        public string description = "DVD Player";
        public string status = "off";
        public string audio = "Surround";
        public string movie = "";
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
            movie = "";
            currentTrack = 0;
            playStatus = "stopped";
        }

        public void pause()
        {
            playStatus = "paused";
        }

        public void stop()
        {
            playStatus = "stopped";
        }

        public void play(string movie)
        {
            this.movie = movie;
            currentTrack = 0;
            playStatus = "playing"; 
        }

        public void play(int track)
        {
            if (movie != "")
            {
                currentTrack = track;
                playStatus = "playing";
            }
        }

        public void setSurroundAudio()
        {
            audio = "surround";
        }

        public void setTowChannelAudio()
        {
            audio = "two channel";
        }

        public void dislayStatus()
        {
            Console.WriteLine("The " + description + " is " + status + ". " + movie + " is " + playStatus + ". The audio is set to " + audio + ".");
        }
    }
}
