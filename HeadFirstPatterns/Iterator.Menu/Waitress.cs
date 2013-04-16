using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Iterator.Menu
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            IIterator pancakeIterator = pancakeHouseMenu.createIterator();
            IIterator dinerIterator = dinerMenu.createIterator();

            Console.WriteLine("MENU\n====\nBreakfast");
            printMenu(pancakeIterator);
            Console.WriteLine("\nLunch");
            printMenu(dinerIterator);
        }

        public void printMenu(IIterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                Console.Write(menuItem.getName() + ", ");
                Console.Write(menuItem.getPrice() + " == ");
                Console.WriteLine(menuItem.getDescription());
            }
        }
    }
}
