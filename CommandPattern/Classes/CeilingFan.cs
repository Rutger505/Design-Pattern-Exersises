namespace CommandPattern.Classes;

internal class CeilingFan
{
    private readonly string location;
    private int speed;

    public CeilingFan(string location)
    {
        this.location = location;
        speed = OFF;
    }

    public int HIGH => 3;
    public int MEDIUM => 2;
    public int LOW => 1;
    public int OFF => 0;

    public void High()
    {
        speed = HIGH;
        Console.WriteLine(location + " is on: " + speed);
    }

    public void Medium()
    {
        speed = MEDIUM;
        Console.WriteLine(location + " is set on: " + speed);
    }

    public void Low()
    {
        speed = LOW;
        Console.WriteLine(location + " is set on: " + speed);
    }

    public void Off()
    {
        speed = OFF;
        Console.WriteLine(location + " is set on: " + speed);
    }

    public int GetSpeed()
    {
        return speed;
    }
}