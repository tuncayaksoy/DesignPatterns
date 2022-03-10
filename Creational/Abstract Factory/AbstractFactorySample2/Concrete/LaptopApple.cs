using System;
using AbstractFactory.AbstractFactorySample2.Absract;

namespace AbstractFactory.AbstractFactorySample2.Concrete
{
    public class LaptopApple : ILaptop
    {
        public LaptopApple()
        {
            Console.WriteLine("Apple ürünü oluşturuldu.");
        }

        public void BuildPart()
        {
            Console.WriteLine("Apple ürününün parçaları oluşturuldu.");
        }
    }
}
