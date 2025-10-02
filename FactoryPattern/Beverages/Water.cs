namespace FactoryPattern.Beverages;

internal class Water : Beverage
{
    public Water(Beverage beverage = null)
    {
        description = "Water";
        baseBeverage = beverage;
    }

    public override string GetDescription()
    {
        if (baseBeverage != null) return baseBeverage.GetDescription() + ", " + description;
        return description;
    }

    public override double cost()
    {
        if (baseBeverage != null) return 0.50 + baseBeverage.cost();
        return 0.50;
    }
}