namespace SingletonPattern;

public class Dawg
{
    private static Dawg _instance;

    private Dawg()
    {
    }

    private int woofCount = 0;

    public static Dawg GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Dawg();
        }

        return _instance;
    }


    public void Woof()
    {
        woofCount++;
        Console.WriteLine($"Woof! (x{woofCount})");
    }
}