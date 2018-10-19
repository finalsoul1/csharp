using System;


namespace Hw1016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요(,로 구분): ");
            string str = Console.ReadLine();
            string[] sArr = str.Split(new char[] { ',' });
            int[] iArr = Array.ConvertAll(sArr, s => int.Parse(s));

            Console.WriteLine("입력값");
            foreach (int i in iArr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n------------");

            // 2. 버블정렬
            int[] bArr = iArr;
            int temp = 0;
            for(int i = 1; i < bArr.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(bArr[j] > bArr[i])
                    {
                        temp = bArr[i];
                        bArr[i] = bArr[j];
                        bArr[j] = temp;
                    }
                }
            }
            // 출력
            Console.WriteLine("버블정렬 결과");
            foreach (int i in bArr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n------------");

            // 3. 선택정렬
            int[] selArr = iArr;

            for(int i = 0; i < selArr.Length - 1; i++)
            {
                int minindex = i;
                for (int j = i + 1; j < selArr.Length; j++)
                {
                    if(selArr[i] > selArr[j])
                    {
                        minindex = j;
                    }                    
                }
                temp = selArr[minindex];
                selArr[minindex] = selArr[i];
                selArr[i] = temp;
            }
            Console.WriteLine("선택정렬 결과");
            foreach (int i in selArr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n------------");

            //////////////////////////////////////////////////////
            //////////////////////////////////////////////////////

            Console.WriteLine("두수를 입력하세요.");
            Console.WriteLine("예 : 3,5");
            string str1 = Console.ReadLine();
            str1.Trim();
            string[] str1arr = str1.Split(',');
            if (str1arr.Length != 2)
            {
                Console.WriteLine("숫자2개를 콤마로 구분해서 입력하세요~");
                return;
            }
            int first, second;
            try
            {
                first = int.Parse(str1arr[0]);
                second = int.Parse(str1arr[1]);
            }
            catch
            {
                Console.WriteLine("입력이 잘못되었습니다.");
                return;
            }
            Console.WriteLine("{0} + {1} = {2}", first, second, Calc(first, second, "+"));
            Console.WriteLine("{0} - {1} = {2}", first, second, Calc(first, second, "-"));
            Console.WriteLine("{0} * {1} = {2}", first, second, Calc(first, second, "*"));
            Console.WriteLine("{0} / {1} = {2}", first, second, Calc(first, second, "/"));
        }
        static double Calc(int first, int second, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = (double)first + second;
                    break;
                case "-":
                    result = (double)first - second;
                    break;
                case "*":
                    result = (double)first * second;
                    break;
                case "/":
                    result = (double)first / second;
                    break;
            }
            return result;
        }
    }
}
