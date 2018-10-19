using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p64
{
    interface Dog // 안에 올 수 있는 것 메소드, 속성, 이벤트, 인덱서,, 필드(멤버) x
    {
        string name { get; set; } // 속성
        void jitda(); // 추상메소드
    }
    class Pudle : Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + " 짖다~~~~");
        }
        public void work()
        {
            Console.WriteLine(name + "가 일한다.");
        }
    }
    class Jindo : Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + " 짖다~~~~");
        }
        public void run()
        {
            Console.WriteLine(name + "가 달린다.");
        }
    }

    class DogManager
    {
        static void Main()
        {
            Dog p = new Pudle();
            Pudle pp = (Pudle)p;
            p.name = "푸들이";
            p.jitda(); 
            ((Pudle)p).work();

            Dog j = new Jindo();
            j.name = "진돌이";
            j.jitda(); 
            ((Jindo)j).run();
        }
    }
}
