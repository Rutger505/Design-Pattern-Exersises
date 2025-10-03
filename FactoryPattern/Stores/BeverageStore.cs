using FactoryPattern.Beverages;

namespace FactoryPattern.Stores;

internal interface IBeverageStore
{
    Beverage CreateBeverage(Beverages type);
}