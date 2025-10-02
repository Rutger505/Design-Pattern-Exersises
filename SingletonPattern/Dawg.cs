namespace SingletonPattern;

public class Dawg
{
    private static Dawg _instance;

    private int woofCount;

    private Dawg()
    {
        DoStuffThatTakesLong();
    }

    private void DoStuffThatTakesLong()
    {
        Thread.Sleep(300);
    }

    public static Dawg GetInstance()
    {
        if (_instance == null)
            lock (_instance)
            {
                if (_instance == null)
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