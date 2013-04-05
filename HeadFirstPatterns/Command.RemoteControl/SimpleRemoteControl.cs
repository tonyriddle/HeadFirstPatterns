using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl()
        {

        }

        public void setCommand(ICommand command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}
