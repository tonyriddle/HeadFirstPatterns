using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    class StereoOffCommand : ICommand
    {
        Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        #region ICommand Members

        public void execute()
        {
            stereo.off();
        }

        #endregion
    }
}
