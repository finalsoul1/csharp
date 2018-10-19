using System;

namespace Hw1_4

{

    class Program

    {

        static void Main(string[] args)
        {
            // 1. 괄호 채워 주세요.

            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4
            int[][] a = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4 }
            };
            //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)
            int[,] b = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //가변배열 출력
            foreach(int[] i in a)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine("\n---------------\n");

            //이차원 배열 출력

            foreach (int i in b)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n------1번끝-------\n");


            /*
            2.아래와 같은 결과를 만들기 위해 괄호를 채우세요.
            [결과]
            12345678
            12345678
            */

            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            Console.WriteLine(twoDim.GetLength(0));
            Console.WriteLine(twoDim.GetLength(1));

            for (int i = 0; i < twoDim.GetLength(0); i++)
            {
                for (int j = 0; j < twoDim.GetLength(1); j++)
                    Console.Write(twoDim[i, j]);
            }
            Console.WriteLine();

            foreach (int i in twoDim)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            Console.WriteLine("\n------2번끝-------\n");


            // 4. 실행 결과를 만들어 내기 위해 코드를 완성 하세요.
            // Loop over array of integers.
            foreach (int id in GetEmployeeIds())
            {
                Console.WriteLine(id);
            }

            // Loop over array of integers.
            int[] employees = GetEmployeeIds();

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }

            Console.WriteLine("\n------4번끝-------\n");

        }

        /// <summary>
        /// Returns an array of integers.
        /// </summary>
        static int[] GetEmployeeIds()
        {
            int[] employees = new int[5];
            employees[0] = 1;
            employees[1] = 3;
            employees[2] = 5;
            employees[3] = 7;
            employees[4] = 8;

            return employees;
        }
        /*
        Output
        1
        3
        5
        7
        8
        1
        3
        5
        7
        8
        */
    }
}
 