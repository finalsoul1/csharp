using System;

public class Delegate1
{
    //private delegate int OnjSum(int i, int j); // 1. 선언
    public static void Main(string[] args)
    {
        Action<int, int> myMethod = 
            (i, j) => Console.WriteLine(i + j);

        myMethod(10, 30);
    }

}
