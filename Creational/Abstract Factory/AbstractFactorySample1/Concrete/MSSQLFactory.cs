using AbstractFactory.AbstractFactorySample1.Absract;

namespace AbstractFactory.AbstractFactorySample1.Concrete
{
    public class MSSQLFactory : DatabaseFactory
    {
        public override IConnection CreateConnection()
        {
            return (new MSSQLConnection());
        }

        public override ICommand CreateCommand()
        {
            return (new MSSQLCommand());
        }
    }
}
