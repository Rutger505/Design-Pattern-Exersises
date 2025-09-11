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
            Console.WriteLine($"Forecast: More of the same");
        }
    }
}