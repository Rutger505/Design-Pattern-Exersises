using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }

    internal abstract class Beverage(Size size = Size.TALL)

    {
        public Size Size { get; set; } = size;


        protected string description = "Unknown";
        protected Beverage baseBeverage = null;


        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();

        public double CostBySize()
        {
            return Size switch
            {
                Size.VENDI => cost() * 2.0,
                Size.GRANDE => cost() * 1.5,
                Size.TALL => cost() * 1.3,
                _ => throw new Exception("Invalid size")
            };
        }
    }
}