using System;
using AbstractFactory.AbstractFactorySample2.Absract;

namespace AbstractFactory.AbstractFactorySample2.Concrete
{
    public class FactorySamsung : AbstractFactoryTypes
    {
        public override ILaptop CreateLaptop()
        {
            return new LaptopSamsung();
        }

        public override IBag CreateBag()
        {
            return new BagSamsung();
        }
    }
}
