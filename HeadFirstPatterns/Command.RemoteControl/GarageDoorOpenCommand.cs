using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor door;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }

        #region ICommand Members

        public void execute()
        {
            door.up();
        }

        #endregion
    }
}
