using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class ParamsTest
    {
        static void Main()
        {
            ParamsTest p = new ParamsTest();
            Console.WriteLine(p.Sum(1, 2));
            Console.WriteLine(p.Sum(1, 2, 3));
            Console.WriteLine(p.Sum(1, 2, 3, 4, 5, 6, 7));

            Console.WriteLine(p.Sum2(j:1, i:2));

            Console.WriteLine(p.Sum3(j: 1));
        }
        int Sum(params int [] iArray) // 가변길이 매개변수
        {
            int sum = 0;
            foreach (int i in iArray) sum += i;
            return sum;
        }
        int Sum2(int i, int j) // 명명된 인수
        {
            Console.WriteLine("i: {0}, j: {1}", i, j);
            return i + j;
        }
        int Sum3(int i = 0, int j = 0) // 선택적 인수
        {
            Console.WriteLine("i: {0}, j: {1}", i, j);
            return i + j;
        }
    }
}
