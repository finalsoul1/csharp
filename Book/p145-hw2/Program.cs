using System;
public delegate void Callback();
class Program
{
    static void Main(string[] args)
    {
        MyClass my = new MyClass();
        //Direct call
        my.MyMethod1();
        my.MyMethod2();
        Console.WriteLine("------------");

        // Call via a delegate
        // MyClass의 GetCallback(Callback callBack) 메소드를 호출하여
        // MyMethod1, MyMethod2가 호출 되도록 코드를 완성하세요
        Callback callback1 = new Callback(my.MyMethod1);
        Callback callback2 = new Callback(my.MyMethod2);

        Callback callback = callback1 + callback2;

        my.GetCallback(callback);
    }
}
public class MyClass
{
    public MyClass() { }
    public void GetCallback(Callback callBack)
    {
        callBack();
    }
    public void MyMethod1()
    {
        Console.WriteLine("My Method 1");
    }
    public void MyMethod2()
    {
        Console.WriteLine("My Method 2");
    }
}