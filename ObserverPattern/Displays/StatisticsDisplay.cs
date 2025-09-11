using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private int countUpdated = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float newTemperature, float humidity, float pressure)
        {
            temperature = newTemperature;
            sumTemperature += temperature;
            countUpdated++;
            if (maxTemp < temperature)
            {
                maxTemp = temperature;
            }

            if (minTemp > temperature || minTemp == 0)
            {
                minTemp = temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine(
                $"Avg/Max/Min temperature = {sumTemperature / countUpdated}/{maxTemp}/{minTemp}");
        }
    }
}