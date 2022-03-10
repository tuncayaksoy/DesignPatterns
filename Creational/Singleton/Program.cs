using System;
using Singleton.Libs;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1 version1 = Sample1.GetInstance();

            Sample2 version2 = Sample2.GetInstace();

            Sample3 version3 = Sample3.GetInstance();
        }
    }
}
