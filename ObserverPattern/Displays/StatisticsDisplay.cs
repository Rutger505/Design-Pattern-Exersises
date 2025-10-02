using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays;

internal class StatisticsDisplay : Observer, DisplayElement
{
    private int countUpdated;
    private float maxTemp;
    private float minTemp;
    private float sumTemperature;
    private float temperature;
    private Subject weatherData;

    public StatisticsDisplay(Subject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine(
            $"Avg/Max/Min temperature = {sumTemperature / countUpdated}/{maxTemp}/{minTemp}");
    }

    public void Update(float newTemperature, float humidity, float pressure)
    {
        temperature = newTemperature;
        sumTemperature += temperature;
        countUpdated++;
        if (maxTemp < temperature) maxTemp = temperature;

        if (minTemp > temperature || minTemp == 0) minTemp = temperature;

        Display();
    }
}