using AbstractFactory.AbstractFactorySample1.Absract;

namespace AbstractFactory.AbstractFactorySample1.Concrete
{
    public class OracleFactory : DatabaseFactory
    {
        public override IConnection CreateConnection()
        {
            return (new OracleConnection());
        }

        public override ICommand CreateCommand()
        {
            return (new OracleCommand());
        }
    }
}
