using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.State.GumballMachine
{
    public interface IState
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense();
        string getState();
    }
}
