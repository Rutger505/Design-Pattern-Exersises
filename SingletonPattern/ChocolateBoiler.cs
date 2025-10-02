namespace SingletonPattern;

internal class ChocolateBoiler
{
    // This code is only started when the boiler is empty
    public ChocolateBoiler()
    {
        IsEmpty = true;
        IsBoiled = false;
    }

    public bool IsEmpty { get; private set; }

    public bool IsBoiled { get; private set; }

    // To fill the boiler it must be empty and once it is full, we set the empty and boiled flag
    public void fill()
    {
        if (IsEmpty)
        {
            IsEmpty = false;
            IsBoiled = false;
        }
    }

    // To drain the boiler, it must be full (non empty) and also boiled.
    // Once it is drained we set empty back to true
    public void drain()
    {
        if (!IsEmpty && IsBoiled) IsEmpty = true;
    }

    // To boil the mixture, the boiler has to be full and not already boiled.
    // Once it is boiled we set the boiled flag to true
    public void boil()
    {
        if (!IsEmpty && !IsBoiled) IsBoiled = true;
    }
}