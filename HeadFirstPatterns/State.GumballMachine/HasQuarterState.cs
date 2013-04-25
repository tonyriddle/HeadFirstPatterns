using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.State.GumballMachine
{
    public class HasQuarterState : IState
    {
        GumballMachine gumballMachine;
        Random randomWinner = new Random(DateTime.Now.Millisecond);

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        #region IState Members

        public string getState()
        {
            return "Has Quarter";
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(1, 10);
            if ((winner == 1) && (gumballMachine.getCount() > 1))
            {
                gumballMachine.setState(gumballMachine.getWinnerState());
            }
            else
            {
                gumballMachine.setState(gumballMachine.getSoldState());
            }
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed...");
        }

        #endregion
    }
}
