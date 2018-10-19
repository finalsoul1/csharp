using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1015
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 다음과 같은 결과를 출력하는 C# 프로그램을 작성하세요. 2 4 6 8 10

            for(int i = 1; i<=10; i++)
            {
                if (i % 2 == 0) Console.Write("{0} ", i);
            }

            // 2. 숫자를 입력하면 다음과 같이 출력하는 C# 프로그램을 작성하세요. 
            /*
            [출력] 
            입력숫자 : 10
            10까지의 숫자 : 1 2 3 4 5 6 7 8 9 10
            10까지의 숫자합은 : 55
             */
            Console.WriteLine("");
            Console.Write("숫자를 입력하세요 :");

            string str = Console.ReadLine();
            int num;
            if (int.TryParse(str, out num)) Console.WriteLine("입력숫자 : {0}", num);

            Console.Write("10까지의 숫자 : ");
            int sum = 0;
            for (int i = num; i > 0; i--)
            {
                Console.WriteLine("{0}", i);
                sum += i;
            }
            Console.WriteLine("10까지의 숫자합은 : {0}", sum);

            // 3. 10개의 숫자를 입력받아 입력받은 수를 출력하고 합, 평균을 구해 출력하세요. 

            sum = 0;
            Console.WriteLine("Input the 10 numbers : ");
            for(int i = 1; i<=10; i++)
            {
                Console.Write("숫자-{0} : ", i);
                str = Console.ReadLine();
                num = 0;
                if (int.TryParse(str, out num)) sum += num;
            }
            Console.WriteLine("합 : {0}", sum);
            Console.WriteLine("평균 : {0}", (float)sum/10);

            // 4. 다음과 같이 출력결과를 만들어내는 C# 프로그램을 작성하세요.

            Console.Write("출력을 원하는 구구단 단수 : ");
            str = Console.ReadLine();
            num = 0;
            if (int.TryParse(str, out num)) ;

            for(int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= num; j++)
                {
                    Console.Write("{0} x {1} = {2} ", j, i, j * i);
                }
                Console.WriteLine("");
            }

        }
    }
}
