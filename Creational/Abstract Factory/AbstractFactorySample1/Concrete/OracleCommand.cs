using System;
using AbstractFactory.AbstractFactorySample1.Absract;

namespace AbstractFactory.AbstractFactorySample1.Concrete
{
    public class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle sorgusu calistiriliyor.");
        }
    }
}
