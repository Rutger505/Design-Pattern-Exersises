using FactoryPattern.Beverages;

namespace FactoryPattern.Stores;

internal class Starbuzz : IBeverageStore
{
    public Beverage CreateBeverage(Beverages type)
    {
        throw new NotImplementedException();
    }
}