/*
5. 실행결과가 아래와 같다.

Enter a Number : 123
Reverse of Entered Number : 321

코드를 완성하세요
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());

            string num2 = "";
            while (num != 0)
            {              
                num2 += num % 10;
                num = num / 10;
            }
            reverse = int.Parse(num2);

            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();

        }
    }
}