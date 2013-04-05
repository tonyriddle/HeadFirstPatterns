using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    public class StereoOnWithCDCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        #region ICommand Members

        public void execute()
        {
            stereo.on();
            stereo.setCd();
            stereo.setVolume(11);
        }

        #endregion
    }
}
