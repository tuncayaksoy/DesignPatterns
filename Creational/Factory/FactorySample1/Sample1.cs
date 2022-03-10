using System;
using Factory.FactorySample1.Abstract;
using Factory.FactorySample1.Concrete;

namespace Factory.FactorySample1
{
    public class Sample1
    {
        public void Show()
        {
            // An array of creators
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }
    }
}
