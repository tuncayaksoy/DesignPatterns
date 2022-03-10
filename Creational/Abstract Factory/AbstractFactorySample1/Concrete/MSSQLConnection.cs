using System;
using AbstractFactory.AbstractFactorySample1.Absract;

namespace AbstractFactory.AbstractFactorySample1.Concrete
{
    public class MSSQLConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("MSSQL baglantisi kuruldu.");
        }

        public void Disconnect()
        {
            Console.WriteLine("MSSQL baglantisi sonlandırıldı.");
        }
    }
}
