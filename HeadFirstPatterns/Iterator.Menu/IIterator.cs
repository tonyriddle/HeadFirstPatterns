using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Iterator.Menu
{
    public interface IIterator
    {
        bool hasNext();
        Object next();
    }
}
