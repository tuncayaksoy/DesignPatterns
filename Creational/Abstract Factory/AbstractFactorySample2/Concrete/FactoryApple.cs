using System;
using AbstractFactory.AbstractFactorySample2.Absract;

namespace AbstractFactory.AbstractFactorySample2.Concrete
{
    public class FactoryApple : AbstractFactoryTypes
    {
        public override ILaptop CreateLaptop()
        {
            return new LaptopApple();
        }

        public override IBag CreateBag()
        {
            return new BagApple();
        }
    }
}
