using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class VanillaSugar : CondimentDecorator
{
    public VanillaSugar(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.20 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", VanillaSugar";
    }
}