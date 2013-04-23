using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Composite.Menu
{
    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
            allMenus.print();
        }
    }
}
