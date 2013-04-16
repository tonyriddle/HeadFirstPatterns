using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Iterator.Menu
{
    public class PancakeHouseMenuIterator : IIterator
    {
        ArrayList menuItems;
        int position = 0;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            this.menuItems = menuItems;
        }

        #region IIterator Members

        public bool hasNext()
        {
            if (position >= menuItems.Count || menuItems[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            MenuItem menuItem = (MenuItem)menuItems[position];
            position = position + 1;
            return menuItem;
        }

        #endregion
    }
}
