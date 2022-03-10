using System;
using AbstractFactory.AbstractFactorySample2.Absract;

namespace AbstractFactory.AbstractFactorySample2.Concrete
{
    public class FactoryProducer
    {
        public static AbstractFactoryTypes GetFactoryLaptop(string computerName)
        {
            if (computerName.ToUpper() == "APPLE")
            {
                return new FactoryApple();
            }
            if (computerName.ToUpper() == "SAMSUNG")
            {
                return new FactorySamsung();
            }
            else
            {
                throw new NotSupportedException("Desteklenmeyen bilgisayar türü");
            }
        }
    }
}
