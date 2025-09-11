using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            weatherData.RegisterObserver(this);
            this.weatherData = weatherData;
        }

        public void Update(float newTemperature, float newHumidity, float _)
        {
            this.temperature = newTemperature;
            this.humidity = newHumidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}°C {humidity}% humidity");
        }
    }
}