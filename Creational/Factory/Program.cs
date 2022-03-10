using System;
using Factory.FactorySample1;
using Factory.FactorySample2;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1 sample1 = new Sample1();

            sample1.Show();

            Console.WriteLine("---------------------------------");

            Sample2 sample2 = new Sample2();

            sample2.Show();
        }
    }
}
