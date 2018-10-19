using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p157
{
    class EventPublisher
    {
        public event EventHandler MyEvent; //이벤트 정의
        public void Do()
        {
            
            MyEvent?.Invoke(null, null);
            MyEvent(null, null);

        }
    }
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();

            p.MyEvent += new EventHandler(doAction);

            p.MyEvent += doAction;

            p.MyEvent += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };

            p.MyEvent += (sender, e) =>
            {
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };
            p.Do();
        }

        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생");
        }
    }
}
