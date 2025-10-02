namespace DecoratorPattern.Beverages;

internal enum Size
{
    TALL,
    GRANDE,
    VENDI
}

internal abstract class Beverage(Size size = Size.TALL)

{
    protected Beverage baseBeverage = null;


    protected string description = "Unknown";
    public Size Size { get; set; } = size;


    public virtual string GetDescription()
    {
        return description;
    }

    public abstract double cost();

    public double CostBySize()
    {
        return Size switch
        {
            Size.VENDI => cost() * 2.0,
            Size.GRANDE => cost() * 1.5,
            Size.TALL => cost() * 1.3,
            _ => throw new Exception("Invalid size")
        };
    }
}