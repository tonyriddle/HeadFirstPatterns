using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Observer.Weather
{
    class AveragetemperatureDisplay : IWeatherObserver, IDisplayElement
    {
        List<float> temperatures;
        List<float> humidities;
        List<float> pressures;
        IWeatherProvider weatherData;

        public AveragetemperatureDisplay(IWeatherProvider wd)
        {
            weatherData = wd;
            temperatures = new List<float>();
            humidities = new List<float>();
            pressures = new List<float>();
        }

        public void registerDisplay()
        {
            weatherData.registerObserver(this);
        }

        public void removeDisplay()
        {
            weatherData.removeObserver(this);
        }

        #region IWeatherObserver Members

        public void update(float temp, float hum, float press)
        {
            temperatures.Add(temp);
            humidities.Add(hum);
            pressures.Add(press);
            display();
        }

        #endregion

        #region IDisplayElement Members

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("This is the Average Weather Display");
            Console.WriteLine("The average temperature is: " + Sum(temperatures) / temperatures.Count);
            Console.WriteLine("The average humidity is: " + Sum(humidities) / humidities.Count);
            Console.WriteLine("The average pressure is: " + Sum(pressures) / pressures.Count);
            Console.WriteLine();
        }

        private float Sum(List<float> values)
        {
            float total = 0.0F;
            foreach (float value in values)
            {
                total = total + value;
            }
            return total;
        }

        #endregion
    }
}
