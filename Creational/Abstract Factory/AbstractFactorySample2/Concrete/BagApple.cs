using System;
using AbstractFactory.AbstractFactorySample2.Absract;

namespace AbstractFactory.AbstractFactorySample2.Concrete
{
    public class BagApple : IBag
    {
        public BagApple()
        {
            Console.WriteLine("Apple çantası oluşturuldu");
        }

        public void AddLogo()
        {
            Console.WriteLine("Apple logosu eklendi.");
        }
    }
}
