using System;

public class Delegate1
{
    //private delegate int OnjSum(int i, int j); // 1. 선언
    public static void Main(string[] args)
    {
        Func<int, int, int> myMethod = new Delegate1().Sum; // new 생략가능
        // 미리 선언된 델리게이터 Func, Action
        // <파라미터형, 가장 오른쪽에 리턴자료형>
                
        Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
    }
    int Sum(int i, int j)
    {
        return i + j;
    }
}
