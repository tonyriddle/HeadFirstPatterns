using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    class GarageDoorDownCommand : ICommand
    {
        GarageDoor door;

        public GarageDoorDownCommand(GarageDoor door)
        {
            this.door = door;
        }
        #region ICommand Members

        public void execute()
        {
            door.down();
        }

        #endregion
    }
}
