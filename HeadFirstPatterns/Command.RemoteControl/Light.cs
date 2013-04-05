using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HeadFirstPatterns.Command.RemoteControl
{
    public class Light
    {
        public string name = "";
        public bool status = false;

        public Light(string name)
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
            getStatus();
        }

        public void getStatus()
        {
            string strStatus = "";
            if (status)
            {
                strStatus = "on";
            }
            else
            {
                strStatus = "off";
            }
            Console.WriteLine("The " + name + " is " + strStatus);

        }
    }
}
