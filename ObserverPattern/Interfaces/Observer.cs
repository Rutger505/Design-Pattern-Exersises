namespace ObserverPattern.Interfaces;

internal interface Observer
{
    void Update(float newTemperature, float humidity, float pressure);
}