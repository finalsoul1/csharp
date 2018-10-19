using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수 입력 : ");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", num % 2 == 0 ? "짝수" : "홀수");
        }
    }
}
