using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.State.GumballMachine
{
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public string getState()
        {
            return "Sold Out";
        }

        #region IState Members

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, there are no gumballs");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        #endregion
    }
}
