using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class BlackChocolate : CondimentDecorator
{
    public BlackChocolate(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.35 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", BlackChocolate";
    }
}