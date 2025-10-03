using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Lemon : CondimentDecorator
{
    public Lemon(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.25 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", Lemon";
    }
}