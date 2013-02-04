using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Singleton.Chocolate
{
    public sealed class ChocolateBoiler
    {
        private static bool empty;
        private static bool boiled;
        private static volatile ChocolateBoiler chocolateBoiler;
        private static object syncRoot = new Object();


        private ChocolateBoiler()
        {
        }

        //ms recommended way of double locking singleton
        //close to book, but use a static property instead of a static method to get a new instance
        public static ChocolateBoiler ChocolateBoilerInstance
        {
            get
            {
                if (chocolateBoiler == null)
                {
                    lock (syncRoot)
                    {
                        if (chocolateBoiler == null)
                        {
                            chocolateBoiler = new ChocolateBoiler();
                            empty = true;
                            boiled = false;
                        }
                    }
                }
                return chocolateBoiler;
            }
        }

        public void fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Filling Boiler...");
            }
            else
            {
                Console.WriteLine("Cannot fill, boiler is full...");
            }
        }

        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                empty = true;
                Console.WriteLine("Draining Boiler...");
            }
            else
            {
                Console.WriteLine("Cannot drain, either it's empty or is not boiled...");
            }
        }

        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                boiled = true;
                Console.WriteLine("Boiling...");
            }
            else
            {
                Console.WriteLine("Cannot boil, either empty, or already boiled");
            }
        }

        private bool isEmpty()
        {
            return empty;
        }

        private bool isBoiled()
        {
            return boiled;
        }
    }
}
