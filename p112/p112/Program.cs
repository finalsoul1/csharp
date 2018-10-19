/*
[LAB]
인터페이스 구현예제.괄호를 채우고 결과를 예측하세요
아래 예제는 두 클래스 Car, Emp가 IEquatable<T> 인터페이스를 구현하여
두 객체가 같은지를 비교하여 참/거짓을 리턴하는 Equals 메소드를 만드는
예문 입니다.괄호를 채우고 결과를 예측하세요.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication2
{
    interface IEquatable<T>
    {
        bool Equals(T obj);
    }
    public class Emp : IEquatable<Emp>
    {
        public string name { get; set; }
        public int sabun { get; set; }
        // Implementation of IEquatable<T> interface
        // name, sabun이 같을 경우 true 리턴
        public bool Equals(Emp e)
        {
            if (this.name.Equals(e.name) && this.sabun == e.sabun)
            {
                return true;
            }
            else return false;
        }
    }
    public class Car : IEquatable<Car>
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        // Implementation of IEquatable<T> interface
        // Maker, Model, Year가 같을 경우 true 리턴
        public bool Equals(Car car)
        {
            if (this.Maker.Equals(car.Maker) && this.Model.Equals(car.Model) && this.Year.Equals(car.Year))
            {
                return true;
            }
            else return false;
        }
    }
    public class CarTest
    {
        static void Main()
        {
            Car c1 = new Car()
            {
                Maker = "현대",
                Model = "그랜저",
                Year = "2016"
            };
            Car c2 = new Car()
            {
                Maker = "현대",
                Model = "그랜저",
                Year = "2015"
            };
            if (c1.Equals(c2))
            {
                Console.WriteLine("c1와 c2는 같다.");
            }
            else
            {
                Console.WriteLine("c1와 c2는 다르다.");
            }

            Emp e1 = new Emp()
            {
                name = "홍길이",
                sabun = 1004
            };
            Emp e2 = new Emp()
            {
                name = "홍길이",
                sabun = 1004
            };

            if (e1.Equals(e2))
            {
                Console.WriteLine("e1와 e2는 같다.");
            }
            else
            {
                Console.WriteLine("e1와 e2는 다르다.");
            }
        }
    }
}