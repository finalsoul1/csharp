using System;

public class Delegate1
{
    //private delegate int OnjSum(int i, int j); // 1. 선언
    public static void Main(string[] args)
    {
        Action<int, int> myMethod = delegate (int i, int j)
        {
            Console.WriteLine(i + j);
        };
        // 미리 선언된 델리게이터 Func, Action
        // Func<파라미터 자료형, 가장 오른쪽에 리턴자료형> : 리턴있는 메소드
        // Action<파라미터 자료형> : 리턴없는 메소드

        myMethod(10, 30);
    }
    
}
