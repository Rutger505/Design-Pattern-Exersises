namespace FactoryPattern.Beverages;

internal enum Size
{
    Tall,
    Grande,
    Vendi
}

internal abstract class Beverage
{
    protected Beverage? BaseBeverage = null;
    protected string Description = "Unknown";
    public Size Size { get; set; } = Size.Tall;

    public virtual string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();

    public double CostBySize()
    {
        return Size switch
        {
            Size.Vendi => Cost() * 2.0,
            Size.Grande => Cost() * 1.5,
            Size.Tall => Cost() * 1.3,
            _ => throw new Exception("Invalid size")
        };
    }
}