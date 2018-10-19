using System;


namespace EventTest
{
    delegate void MyDelegate(int i);
    class EventPublisher
    {
        public event MyDelegate ClapEvent;

        public void Clap(int num)
        {
            if (num % 2 == 0) ClapEvent(num);
        }
    }

    class EventSub
    {
        public static void Main()
        {
            EventPublisher p = new EventPublisher();
            p.ClapEvent += new MyDelegate(Caller);
            p.ClapEvent += new MyDelegate(babo);
            p.ClapEvent += new MyDelegate(new EventSub().pow);

            int[] iArr = Array.ConvertAll(
                (Console.ReadLine()).Split(','), i => int.Parse(i) 
                );

            foreach(int i in iArr)
            {
                p.Clap(i);
            }
        }
        static void Caller(int num)
        {
            Console.WriteLine("{0} : 짝~", num);
        }
        static void babo(int num)
        {
            Console.WriteLine("{0} : 바보바보", num);
        }
        public void pow(int num)
        {
            Console.WriteLine("{0}의 제곱은? : {1}", num, num*num);
        }
    }
}
