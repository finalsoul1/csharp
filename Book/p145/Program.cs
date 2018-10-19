using System;


namespace p145
{
    class Sem
    {
        public int[] arr;

        public Sem(int[] arr)
        {
            this.arr = arr;
        }

        public double Sum()
        {
            int sum = 0;
            foreach (int i in arr) sum += i;
            return sum;
        }
        public double Avg()
        {
            return Sum() / arr.Length;
        }
    }

    class Program
    {
        static int[] iArr;

        void SumP(Sem a) {
            Console.WriteLine("합계 : {0}", new Sem(iArr).Sum());
        }
        void AvgP(Sem a) {
            Console.WriteLine("평균 : {0}", a.Avg());
        }
        void Read()
        {
            Console.Write("정수를 입력하세요(,로 구분): ");
            string str = Console.ReadLine();
            string[] sArr = str.Split(new char[] { ',' });
            iArr = Array.ConvertAll(sArr, s => int.Parse(s));
        }

        static void Main(string[] args)
        {

            Console.Write("입력받은수 : ");
            for(int i = 0; i < iArr.Length; i++)
            {
                Console.Write("{0}{1}", iArr[i], i == iArr.Length-1 ? "" : ", ");
            }
            Console.WriteLine();

            Console.WriteLine("델리케이트 체인");

            Action<Sem> Callback = (Action<Sem>)Delegate.Combine(
                new Action<Sem>(new Program().SumP),
                new Action<Sem>(new Program().AvgP)
                );

            Callback(new Sem(iArr));

            Console.WriteLine("델리케이트 멀티캐스팅");

            Action<Sem> Callback1 = new Action<Sem>(new Program().SumP);
            Action<Sem> Callback2 = new Action<Sem>(new Program().AvgP);

            Action<Sem> Callback3 = Callback1 + Callback2;
            Callback3(new Sem(iArr));
        }
    }
}
