using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float newTemperature, float newHumidity, float _)
        {
            temperature = newTemperature;
            humidity = newHumidity;

            Display();
        }

        public void Display()
        {
            if (humidity < 50)
            {
                Console.WriteLine("It's going to be sunny");
            }
            else if (humidity >= 50 && humidity < 80)
            {
                Console.WriteLine("It's going to be cloudy");
            }
            else
            {
                Console.WriteLine("It's going to rain");
            }

            if (temperature < 20)
            {
                Console.WriteLine("It's going to be cold");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("It's going to be warm");
            }
            else
            {
                Console.WriteLine("It's going to be hot");
            }
        }
    }
}