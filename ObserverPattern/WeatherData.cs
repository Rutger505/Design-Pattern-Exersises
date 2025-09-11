using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class WeatherData : Subject
    {
        private List<Observer> observers = new List<Observer>();
        private float temperature;
        private float humidity;
        private float pressure;

        public void NotifyObservers()
        {
            observers.ForEach((o) => o.Update(temperature, humidity, pressure));
        }

        public void RegisterObserver(Observer o)
        {
            if (observers.Contains(o))
            {
                Console.WriteLine("Observer already registered");
                return;
            }

            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            if (!observers.Contains(o))
            {
                Console.WriteLine("Observer not registered");
                return;
            }

            observers.Remove(o);
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float newTemperature, float newHumidity, float newPressure)
        {
            temperature = newTemperature;
            humidity = newHumidity;
            pressure = newPressure;

            MeasurementChanged();
        }
    }
}