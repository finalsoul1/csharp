using System;

class CreditCard
{
    public string name;
}
class Customer
{
    public int age; // 인스턴스 int 기본값: 0
    public CreditCard card; // 인스턴스 object 기본값: null
    public object ShallowCopy()
    {
        return this.MemberwiseClone(); // object.MemberwiseClone(): 얕은복사
    }
}
class ArrayTest
{
    static void Main()
    {
        Customer c1 = new Customer();
        c1.age = 20;
        c1.card = new CreditCard();
        c1.card.name = "비씨카드";
        Customer c2 = (Customer)c1.ShallowCopy();
        c2.card.name = "BC카드";
        Console.WriteLine("c1.card.name = " + c1.card.name);
        Console.WriteLine("c2.card.name = " + c2.card.name);
    }
}