namespace FactoryPattern.Beverages;

internal class Espresso : Beverage
{
    public Espresso(Beverage? beverage = null)
    {
        Description = "Espresso";
        BaseBeverage = beverage;
    }

    public override string GetDescription()
    {
        if (BaseBeverage != null) return BaseBeverage.GetDescription() + ", " + Description;

        return Description;
    }

    public override double Cost()
    {
        if (BaseBeverage != null) return 1.99 + BaseBeverage.Cost();

        return 1.99;
    }
}