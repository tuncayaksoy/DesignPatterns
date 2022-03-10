namespace AbstractFactory.AbstractFactorySample1.Absract
{
    public abstract class DatabaseFactory
    {
        public abstract IConnection CreateConnection();

        public abstract ICommand CreateCommand();
    }
}
