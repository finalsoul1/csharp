using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161
{

    class Program
    {
        delegate int Sem(int i);
        static void Main(string[] args)
        {
            //int[] iArr = Array.ConvertAll(
            //            (Console.ReadLine()).Split(','),
            //            i => int.Parse(i));
            Console.Write("정수 입력 : ");

            int num = int.Parse(Console.ReadLine());

            Sem pow = a => a * a;

            Console.WriteLine("{0}의 제곱근 : {1}", num, pow(num));


            

        }
    }
}
