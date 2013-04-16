using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Iterator.Menu
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        #region IIterator Members

        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
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
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }

        #endregion
    }
}
