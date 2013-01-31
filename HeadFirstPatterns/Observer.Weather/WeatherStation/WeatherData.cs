using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Observer.Weather
{
    public class WeatherData : IWeatherProvider
    {
        #region IWeatherProvider Members
        private List<IWeatherObserver> observers;
        private float tempurature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IWeatherObserver>();
        }

        public void registerObserver(IWeatherObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IWeatherObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (IWeatherObserver observer in observers)
            {
                observer.update(tempurature, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temp, float hum, float press)
        {
            tempurature = temp;
            humidity = hum;
            pressure = press;
            measurementsChanged();
        }

        #endregion
    }
}
