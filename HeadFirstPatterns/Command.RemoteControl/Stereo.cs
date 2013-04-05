using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    public class Stereo
    {
        public string name = "";
        public bool status = false;
        public bool cd = false;
        public bool dvd = false;
        public bool radio = false;
        public int volume = 0;

        public Stereo(string name)
        {
            this.name = name;
        }

        public void on()
        {
            status = true;
            getStatus();
        }

        public void off()
        {
            status = false;
            volume = 0;
            cd = false;
            dvd = false;
            radio = false;
            getStatus();
        }

        public void setCd()
        {
            dvd = false;
            radio = false;
            cd = true;
            getStatus();
        }

        public void setDvd()
        {
            radio = false;
            cd = false;
            dvd = true;
            getStatus();
        }

        public void setRadio()
        {
            cd = false;
            dvd = false;
            radio = true;
            getStatus();
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
            getStatus();
        }

        public void getStatus()
        {
            string status;
            if (this.status)
            {
                status = "on";
            }
            else
            {
                status = "off";
            }

            string input = "no";
            if (cd)
            {
                input = "cd";
            }
            if (dvd)
            {
                input = "dvd";
            }
            if (radio)
            {
                input = "radio";
            }

            Console.WriteLine("The " + name + " is " + status + ". It is set for " + input + " input. The volume is " + this.volume.ToString() + ".");
        }
    }
}
