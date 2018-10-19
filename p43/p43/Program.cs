using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p43
{
    class Emp
    {
        string name; // c#에서는 기본범위연산자가 private
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
    }
    class Emp2
    {
        // c#프로퍼티
        private string name;
        public string Name // name변수를 가리키고 있다.
        {
            get
            {
                return this.name; // 앞으로 생길 객체의 객체참조
            }
            set
            {
                this.name = value; // value: 들어오는값
            }
        }
    }
    class Emp3
    {
        // c#프로퍼티 자동구현속성
        public string Name
        {
            get; set;
        }
    }

    class EmpTest
    {
        static void Main()
        {
            Emp e = new Emp();
            e.SetName("KiM1");
            Console.WriteLine(e.GetName());

            Emp2 e2 = new Emp2();
            e2.Name = "KIM2"; // 프로퍼티는 변수처럼 쓸 수 있다.
            Console.WriteLine(e2.Name);

            Emp3 e3 = new Emp3();
            e3.Name = "KIM3"; 
            Console.WriteLine(e3.Name);
        }
    }
}
