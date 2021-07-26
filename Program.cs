using System;
using dp.net.adapter;
using dp.net.chain_of_responsibility;
using DP.net.singleton;

namespace DP.net
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton

            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            if (s1 == s2)
            {
                System.Console.WriteLine("Singleton works! ");
            }
            else
            {
                System.Console.WriteLine("Singleton not work");
            }
            s2.DoWork();

            #endregion


            #region Chain Of Responsibility
            AbsBillHandler bill200 = new BillHandler200();
            AbsBillHandler bill100 = new BillHandler100();
            AbsBillHandler bill50 = new BillHandler50();
            AbsBillHandler bill20 = new BillHandler20();

            bill200.SetNext(bill100);
            bill100.SetNext(bill50);
            bill50.SetNext(bill20);
            bill20.SetNext(null); // emphasis that thisis the last handler

            System.Console.WriteLine();
            System.Console.WriteLine("****** runnign Chain Of Responsibility Pattern *****");
            System.Console.WriteLine();
            System.Console.WriteLine("Withdraw 770");
            bill200.HandleRequest(770);
            System.Console.WriteLine();
            System.Console.WriteLine("Withdraw 100");
            bill200.HandleRequest(100);
            System.Console.WriteLine();
            System.Console.WriteLine("Withdraw 210");
            bill200.HandleRequest(210);
            System.Console.WriteLine();
            System.Console.WriteLine("****** Chain Of Responsibility Done ******");
            System.Console.WriteLine();

            #endregion

            #region Adapter

            IScientificCalc scientificCalc = new ScientificCalc();
            double x = new Random().NextDouble() * 1000;
            double y = new Random().NextDouble() * 1000;
            PrintMathREsults(scientificCalc, x, y);

            IScientificCalc adapterCalc = new AdapterCalc();
            int xInt = new Random().Next() * 1000;
            int yInt = new Random().Next() * 1000;
            PrintMathREsults(adapterCalc, x, y);

            #endregion

            #region factory Method

            #endregion
        }

        #region Adapter
        static void PrintMathREsults(IScientificCalc calc, double x, double y)
        {
            System.Console.WriteLine(calc.Add(x, y));
            System.Console.WriteLine(calc.Sub(x, y));
            System.Console.WriteLine(calc.Div(x, y));
            System.Console.WriteLine(calc.Mul(x, y));
        }
        #endregion

    }
}
