using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Observer.Weather
{
    public class CurrentConditionsDisplay : IDisplayElement, IWeatherObserver
    {
        private float tempurature;
        private float humidity;
        private float pressure;
        private IWeatherProvider weatherData;
        
        public CurrentConditionsDisplay(IWeatherProvider wd)
        {
            weatherData = wd;
            tempurature = 0.0F;
            humidity = 0.0F;
            pressure = 0.0F;
        }

        public void registerDisplay()
        {
            weatherData.registerObserver(this);
        }

        public void removeDisplay()
        {
            weatherData.removeObserver(this);
        }

        #region IDisplayElement Members

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("This is the Current Condition Display");
            Console.WriteLine("The current tempurature is: " + tempurature.ToString());
            Console.WriteLine("The current humidity is: " + humidity.ToString());
            Console.WriteLine("The current pressure is: " + pressure.ToString());
            Console.WriteLine();
        }

        #endregion

        public void update(float temp, float hum, float press)
        {
            tempurature = temp;
            humidity = hum;
            pressure = press;
            display();
        }
    }
}
