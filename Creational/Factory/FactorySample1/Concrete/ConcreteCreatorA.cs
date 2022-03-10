using Factory.FactorySample1.Abstract;

namespace Factory.FactorySample1.Concrete
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
