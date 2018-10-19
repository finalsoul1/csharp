using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p68
{
    class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine(">>> MyBaseClass()");
        }
        public MyBaseClass(int i)
        {
            Console.WriteLine(">>> MyBaseClass(int i)");
        }
    }

    class MyClass : MyBaseClass
    {
        public MyClass()
        {
            // 부모생성자 호출
            Console.WriteLine(">>> MyClass()");
        }
        public MyClass(int i) : base(i)
        {
            Console.WriteLine(">>> MyClass(int i)");
        }
        public MyClass(int i, int j)
        {
            Console.WriteLine(">>> MyClass(int i, int j)");
        }
        public MyClass(int i, int j, int k) : base(i)
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k)");
        }
        public MyClass(int i, int j, int k, int l) : this(i, j) 
            // this() 자기자신의 또다른 생성자, c#에선 super 대신 base
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k, int l)");
        }

    }

    class Test
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            Console.WriteLine("");
            MyClass m2 = new MyClass(1);
            Console.WriteLine("");
            MyClass m3 = new MyClass(1, 2);
            Console.WriteLine("");
            MyClass m4 = new MyClass(1, 2, 3);
            Console.WriteLine("");

            MyClass m5 = new MyClass(1, 2, 3, 4);
        }
    }
}
