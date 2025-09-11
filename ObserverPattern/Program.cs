using ObserverPattern.Displays;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays
            CurrentConditionDisplay currentDisplay = new(weatherData);
            StatisticsDisplay statisticsDisplay = new(weatherData);
            ForecastDisplay forecastDisplay = new(weatherData);

            weatherData.SetMeasurements(28, 65, 30.4f);
            weatherData.SetMeasurements(29, 70, 29.2f);

            weatherData.RemoveObserver(forecastDisplay);

            weatherData.SetMeasurements(30, 90, 29.2f);
        }
    }
}