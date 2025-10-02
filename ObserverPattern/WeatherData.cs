using ObserverPattern.Interfaces;

namespace ObserverPattern;

internal class WeatherData : Subject
{
    private readonly List<Observer> observers = new();
    private float humidity;
    private float pressure;
    private float temperature;

    public void NotifyObservers()
    {
        observers.ForEach(o => o.Update(temperature, humidity, pressure));
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