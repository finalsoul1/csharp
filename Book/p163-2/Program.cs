﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p163_2
{
    delegate bool Onj1();
    delegate bool Onj2(int i);

    class Program
    {
        Onj1 onj1;
        Onj2 onj2;

        public void MyMethod(int input)
        {
            int onjVal = 0;
            onj1 = () =>
            {
                onjVal = 999;
                return input > onjVal;
            };

            onj2 = (x) => { return x == onjVal; };

            // 델리게이트가 아직 호출되지않음,
            Console.WriteLine("onjVal 아직 {0}", onjVal);

            bool myRet1 = onj1();
            Console.WriteLine("onj1 :: 메소드 입력값이 999보다 큰가? {0}", myRet1);

            bool myRet2 = onj2(0);
            Console.WriteLine("onj2 :: 메소드 입력값이 0과 같나? {0}", myRet2);

            bool myRet3 = onj2(999);
            Console.WriteLine("onj2 :: 메소드 입력값이 999와 같나? {0}", myRet3);

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.MyMethod(999);
        }
    }
}
