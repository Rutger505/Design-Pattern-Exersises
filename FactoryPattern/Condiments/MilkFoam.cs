using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class MilkFoam : CondimentDecorator
{
    public MilkFoam(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.30 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Milk Foam";
    }
}