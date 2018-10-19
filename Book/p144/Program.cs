using System;
using System.Collections.Generic;
using System.Text;
namespace deledatetest
{
    delegate void OnjDelegate(int a, int b);
    class MainApp
    {
        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }
        static void Main()
        {
            MainApp m = new MainApp();

            OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
              new OnjDelegate(MainApp.Plus),
              new OnjDelegate(MainApp.Minus),
              new OnjDelegate(m.Multiplication),
              new OnjDelegate(m.Division));

            CallBack(4, 3);

            OnjDelegate CallBack2 = new OnjDelegate(MainApp.Plus);
            CallBack2 += new OnjDelegate(MainApp.Minus);
            CallBack2 += new OnjDelegate(m.Multiplication);
            CallBack2 += new OnjDelegate(m.Division);

            CallBack2(5, 4);

            OnjDelegate CallBack3 = new OnjDelegate(MainApp.Plus);
            OnjDelegate CallBack4 = new OnjDelegate(MainApp.Minus);
            OnjDelegate CallBack5 = new OnjDelegate(m.Multiplication);
            OnjDelegate CallBack6 = new OnjDelegate(m.Division);

            OnjDelegate CallBack7 = CallBack3 + CallBack4 + CallBack5 + CallBack6;

            CallBack7(6, 5);

            (new OnjDelegate(MainApp.Plus) + new OnjDelegate(MainApp.Minus)
                + new OnjDelegate(m.Multiplication) + new OnjDelegate(m.Division))(7, 5);
        }
    }
}