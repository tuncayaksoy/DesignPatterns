using System;
using AbstractFactory.AbstractFactorySample1.Absract;

namespace AbstractFactory.AbstractFactorySample1.Concrete
{
    public class OracleConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Oracle baglantisi kuruldu.");
        }

        public void Disconnect()
        {
            Console.WriteLine("Oracle baglantisi sonlandırıldı.");
        }
    }
}
