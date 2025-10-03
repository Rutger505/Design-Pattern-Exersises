namespace FactoryPattern.Beverages;

internal class Water : Beverage
{
    public Water(Beverage? beverage = null)
    {
        Description = "Water";
        BaseBeverage = beverage;
    }

    public override string GetDescription()
    {
        if (BaseBeverage != null) return BaseBeverage.GetDescription() + ", " + Description;
        return Description;
    }

    public override double Cost()
    {
        if (BaseBeverage != null) return 0.50 + BaseBeverage.Cost();
        return 0.50;
    }
}