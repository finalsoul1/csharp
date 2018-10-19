using System;
namespace ConsoleApplication1
{
    //이벤트 게시자 클래스, 이벤트를 발생시키는 객체
    class EventPublisher
    {
        //public delegate void MyEventHandler(); //이벤트처리를위한델리게이트정의
        public event EventHandler MyEvent; //이벤트 정의
        public void Do()
        {
            //이벤트 가입자가 있는지 확인
            //if (MyEvent != null) { MyEvent(); //이벤트 발생 }
            MyEvent?.Invoke(null, null); // ? nullable : null이면 작동안함. 
            MyEvent(null, null);

        }
    }
    //구독자 클래스
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            //구독자의 이벤트 처리 메소드를 등록
            //이벤트를 발생하면 호출될 메소드를 정의, 여기서는 doAction 메소드 호출
            //MyEvent 라는 이벤트에 이벤트핸들러인 델리게이트를 통해 메소드를 등록
            //MyEvent 라는 이벤트가 발생하면 델리게이트가 참조하는 메소드 doAction() 실행
            p.MyEvent += new EventHandler(doAction);
            //테스트를 위해 do() 메소드를 호출하여 이벤트 발생
            //실제 윈폼등에서는 버튼등을 클릭하면 자동으로 이벤트가 발생하지만
            //콘솔 프로그램이라서 메소드를 호출하는 것이다.
            p.Do();
        }
        //MyEvent 라는 이벤트가 발생하면 호출되는 메소드
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }
}
