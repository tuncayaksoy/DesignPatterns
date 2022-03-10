using AbstractFactory.AbstractFactorySample1.Absract;

namespace AbstractFactory.AbstractFactorySample1.Concrete
{
    public class ApplicationProducer
    {
        private DatabaseFactory _databaseFactory;

        private IConnection _connection;

        private ICommand _command;

        public ApplicationProducer(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = databaseFactory.CreateConnection();
            _command = databaseFactory.CreateCommand();
        }

        public void Connect()
        {
            _connection.Connect();
        }

        public void Disconnect()
        {
            _connection.Disconnect();
        }

        public void Execute()
        {
            _command.Execute();
        }
    }
}
