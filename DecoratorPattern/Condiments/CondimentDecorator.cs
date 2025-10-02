using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal abstract class CondimentDecorator : Beverage
{
    public abstract override string GetDescription();
}