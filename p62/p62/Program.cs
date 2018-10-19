using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p62
{
    public abstract class Dog
    {
        public string name { get; set; }
        public abstract void jitda(); // 추상메소드
    }
    public class Pudle : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(name + " 푸들푸들~");
        }
        public void work()
        {
            Console.WriteLine(name + "가 일한다.");
        }
    }
    public class Jindo : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(name + " 진도진도~");
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
            p.jitda(); // 푸들푸들
            ((Pudle)p).work();

            Dog j = new Jindo();
            j.name = "진돌이";
            j.jitda(); // 진도진도
            ((Jindo)j).run();
            // 같은 Dog 타입의 메소드인데 결과가 다양함 -> 다형성
        }
    }
}
