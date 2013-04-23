using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Composite.Menu
{
    public class Menu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        String name;
        String description;

        public Menu(String name, String description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent getChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }

        public override String getName()
        {
            return name;
        }

        public override String getDescription()
        {
            return description;
        }

        public override void print()
        {
            Console.WriteLine(getName() + ", " + getDescription() + "-------------------");

            foreach (MenuComponent menu in menuComponents)
            {
                menu.print();
            }
        }
    }
}
