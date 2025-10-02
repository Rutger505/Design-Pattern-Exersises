using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal abstract class CondimentDecorator : Beverage
{
    public abstract override string GetDescription();
}