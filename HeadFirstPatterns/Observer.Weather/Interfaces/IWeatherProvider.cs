using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Observer.Weather
{
    public interface IWeatherProvider
    {
        void registerObserver(IWeatherObserver o);
        void removeObserver(IWeatherObserver o);
        void notifyObservers();
    }
}
