using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. 사용자로 부터 두수를 입력받아 변수에 넣고 변수값을 뒤짚어서 출력하는 프로그램 입니다.

            Stack num = new Stack();

            Console.Write("첫번째 정수 입력 : ");
            num.Push(int.Parse(Console.ReadLine()));

            Console.Write("두번째 정수 입력 : ");
            num.Push(int.Parse(Console.ReadLine()));

            Console.WriteLine("팝 : {0}, 팝 : {1}", num.Pop(), num.Pop());

            ///////////////////////////////////////////////////////

            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}
