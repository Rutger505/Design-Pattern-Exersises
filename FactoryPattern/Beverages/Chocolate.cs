namespace FactoryPattern.Beverages;

internal class Chocolate : Beverage
{
    public Chocolate(Beverage? beverage = null)
    {
        Description = "Chocolate";
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        if (BaseBeverage != null) return 1.49 + BaseBeverage.Cost();

        return 1.49;
    }

    public override string GetDescription()
    {
        if (BaseBeverage != null) return BaseBeverage.GetDescription() + ", " + Description;

        return Description;
    }
}