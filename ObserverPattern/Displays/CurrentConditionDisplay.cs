using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays;

internal class CurrentConditionDisplay : Observer, DisplayElement
{
    private float humidity;
    private float temperature;
    private Subject weatherData;

    public CurrentConditionDisplay(Subject weatherData)
    {
        weatherData.RegisterObserver(this);
        this.weatherData = weatherData;
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}°C {humidity}% humidity");
    }

    public void Update(float newTemperature, float newHumidity, float _)
    {
        temperature = newTemperature;
        humidity = newHumidity;
        Display();
    }
}