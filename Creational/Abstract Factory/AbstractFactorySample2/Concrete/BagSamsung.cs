using System;
using AbstractFactory.AbstractFactorySample2.Absract;

namespace AbstractFactory.AbstractFactorySample2.Concrete
{
    public class BagSamsung : IBag
    {
        public BagSamsung()
        {
            Console.WriteLine("Samsung çantası oluşturuldu");
        }

        public void AddLogo()
        {
            Console.WriteLine("Samsung logosu eklendi.");
        }
    }
}
