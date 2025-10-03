using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class MilkFoam : CondimentDecorator
{
    public MilkFoam(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.15 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", MilkFoam";
    }
}