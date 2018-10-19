using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 콤마로 구분해서 여러 숫자를 입력받아 합을 구하는 프로그램을 작성하세요.

            int[] iArr = Array.ConvertAll(
                        (Console.ReadLine()).Split(','),
                        i => int.Parse(i));

            Console.WriteLine("{0}", new Program().Sum(iArr));
            
        }
        public int Sum(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
