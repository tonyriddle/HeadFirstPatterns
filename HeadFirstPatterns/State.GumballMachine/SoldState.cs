﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.State.GumballMachine
{
    public class SoldState : IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public string getState()
        {
            return "Sold";
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
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }

        #endregion
    }
}
