using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        #region ICommand Members
        
        public void execute()
        {
            light.on();
        }

        #endregion
    }
}
