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
            Stack num = new Stack();

            Console.Write("정수 두개 입력 : ");

            num.Push(int.Parse(Console.ReadLine()));
            num.Push(int.Parse(Console.ReadLine()));

            Console.WriteLine("{0} ", num.Pop());
            Console.WriteLine("{0} ", num.Pop());

            ///////////////////////////////////////////////////////

            Console.Write("정수 두개 입력 : ");
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
