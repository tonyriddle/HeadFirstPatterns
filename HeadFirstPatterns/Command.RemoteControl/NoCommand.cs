using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Command.RemoteControl
{
    public class NoCommand : ICommand
    {
        #region ICommand Members

        public void execute()
        {
            Console.WriteLine("No Command");
        }

        #endregion
    }
}
