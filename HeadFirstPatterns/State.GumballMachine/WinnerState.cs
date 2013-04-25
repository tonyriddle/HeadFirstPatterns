using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.State.GumballMachine
{
    public class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public string getState()
        {
            return "Winner!";
        }

        #region IState Members

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void turnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void dispense()
        {
            Console.WriteLine("You're a winner! You get two gumballs for your quarter");
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() == 0)
            {
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
            else
            {
                gumballMachine.releaseBall();
                if (gumballMachine.getCount() > 0)
                {
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Opps, out of gumballs");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
            }
        }

        #endregion
    }
}
