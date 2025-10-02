namespace DecoratorPattern.Beverages;

internal class Chocolate : Beverage
{
    public Chocolate(Beverage beverage = null)
    {
        description = "Chocolate";
        baseBeverage = beverage;
    }

    public override double cost()
    {
        if (baseBeverage != null) return 1.49 + baseBeverage.cost();

        return 1.49;
    }

    public override string GetDescription()
    {
        if (baseBeverage != null) return baseBeverage.GetDescription() + ", " + description;

        return description;
    }
}