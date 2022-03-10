using System;
using AbstractFactory.AbstractFactorySample1.Absract;

namespace AbstractFactory.AbstractFactorySample1.Concrete
{
    public class MSSQLCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("MSSQL sorgusu calistiriliyor.");
        }
    }
}
