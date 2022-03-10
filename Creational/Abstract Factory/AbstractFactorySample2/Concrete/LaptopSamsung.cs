using System;
using AbstractFactory.AbstractFactorySample2.Absract;

namespace AbstractFactory.AbstractFactorySample2.Concrete
{
    public class LaptopSamsung : ILaptop
    {
        public LaptopSamsung()
        {
            Console.WriteLine("Samsung ürünü oluşturuldu.");
        }

        public void BuildPart()
        {
            Console.WriteLine("Samsung ürününün parçaları oluşturuldu.");
        }
    }
}
