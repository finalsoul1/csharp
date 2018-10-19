using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p66
{
    class A
    {
        protected A() { }
        ~A() // finalize() 메소드
        {
            System.Console.WriteLine("A 소멸~");
        }
    }

    class B : A
    {
        static void Main(string[] args)
        {
            B a = new B();
            System.GC.Collect();
        }
    }

}
