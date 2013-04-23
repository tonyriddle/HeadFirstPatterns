using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Composite.Menu
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        
        public virtual void remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual MenuComponent getChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual String getName()
        {
            throw new NotImplementedException();
        }

        public virtual String getDescription()
        {
            throw new NotImplementedException();
        }

        public virtual double getPrice()
        {
            throw new NotImplementedException();
        }

        public virtual bool isVegetarian()
        {
            throw new NotImplementedException();
        }

        public virtual void print()
        {
            throw new NotImplementedException();
        }
    }
}
