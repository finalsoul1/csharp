/*
5. 
다이렉트 호출 스크립트 입니다.
*/

using System;
 
namespace Akadia.NoDelegate
{
    public delegate void Callback();
    public class MyClass
    {
        public void Process()
        {
            Console.WriteLine("Process() begin");
            Console.WriteLine("Process() end");
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Process();

            Callback callback = myClass.Process;
            callback();

            Action callback2 = myClass.Process;
            callback2();
        }
    }
}
/*
델리게이트를 사용하여 호출하는 예제로 재작성 하세요.
1. 델리게이트를 별도로 선언하여
2. Action 델리게이트를 이용하여
*/
