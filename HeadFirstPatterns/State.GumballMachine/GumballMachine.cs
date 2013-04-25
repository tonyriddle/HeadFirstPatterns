using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.State.GumballMachine
{
    public class GumballMachine
    {
        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;
        IState winnerState;

        IState state;
        int count = 0;

        public GumballMachine()
        {
            state = soldOutState;
        }

        public int getCount()
        {
            return count;
        }

        public override string ToString()
        {
            return state.getState() + " " + getCount().ToString();
        }

        public GumballMachine(int count)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            this.count = count;
            if (count > 0)
            {
                state = noQuarterState;
            }
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public IState getHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState getSoldOutState()
        {
            return soldOutState;
        }

        public IState getSoldState()
        {
            return soldState;
        }

        public IState getNoQuarterState()
        {
            return noQuarterState;
        }

        public IState getWinnerState()
        {
            return winnerState;
        }

        #region IState Members

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public void refill(int count)
        {
            this.count = count;
            if (state.getState() == getSoldOutState().getState())
            {
                setState(getNoQuarterState());
            }
        }

        #endregion
    }
}
