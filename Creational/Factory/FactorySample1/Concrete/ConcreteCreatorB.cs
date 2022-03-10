using Factory.FactorySample1.Abstract;

namespace Factory.FactorySample1.Concrete
{
    /// <summary>
    /// B 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
