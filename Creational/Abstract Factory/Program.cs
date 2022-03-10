using System;
using AbstractFactory.AbstractFactorySample1.Absract;
using AbstractFactory.AbstractFactorySample1.Concrete;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationProducer msSql =
                new ApplicationProducer(new MSSQLFactory());
            msSql.Connect();
            msSql.Execute();
            msSql.Disconnect();

            Console.WriteLine();

            ApplicationProducer oracle =
                new ApplicationProducer(new OracleFactory());
            oracle.Connect();
            oracle.Execute();
            oracle.Disconnect();
        }
    }
}
