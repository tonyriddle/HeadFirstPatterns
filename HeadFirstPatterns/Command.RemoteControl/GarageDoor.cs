using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    public class GarageDoor
    {
        public string name = "";
        public bool open = false;
        public bool light = false;
        public bool stopped = false;
        
        public GarageDoor(string name)
        {
            this.name = name;
        }

        public void up()
        {
            open = true;
            getStatus();
        }

        public void down()
        {
            open = false;
            getStatus();
        }

        public void stop()
        {
            stopped = true;
            getStatus();
        }

        public void lightOn()
        {
            light = true;
            getStatus();
        }

        public void lightOff()
        {
            light = false;
            getStatus();
        }

        public void getStatus()
        {
            string strUp = "";
            string lightOn = "";
            string isStopped = "";

            if (open)
            {
                strUp = "open";
            }
            else
            {
                strUp = "closed";
            }

            if (light)
            {
                lightOn = "on";
            }
            else
            {
                lightOn = "off";
            }

            if (stopped)
            {
                isStopped = "stopped";
            }
            else
            {
                isStopped = "not stopped";
            }

            Console.WriteLine("The " + name + " is " + strUp + ". The light is " + lightOn + ". The door is " + isStopped + ".");
        }
    }
}
