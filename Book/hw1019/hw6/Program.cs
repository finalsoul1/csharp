using System;

namespace hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. 사용자로 부터 하나의 수를 입력받고 그수까지의 소수의 합을 구하는 프로그램을 작성하세요.

            Console.Write("정수 입력 : ");

            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            Program a = new Program();

            for (int i = 2; i <= num; i++)
            {
                if (a.sosu(i))
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("소수의 합 : {0}", sum);
        }

        public bool sosu(int num)
        {
            if (num <= 1) return false;

            for(int i = 3; i <= num; i++)
            {
                for(int j = 2; j < i; j++)
                {
                    if (num % j == 0) return false;
                }
            }
            return true;
        }
    }
}
