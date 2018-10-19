using System;

public class Delegate1
{
    private delegate int OnjSum(int i, int j); // 1. 선언
    public static void Main(string[] args)
    {
        OnjSum myMethod = new OnjSum(Delegate1.Sum); // 2. 생성, 메소드이름을 인자로

        //OnjSum myMethod = new OnjSum(Sum); //2. 생성
        //OnjSum myMethod = Sum; //2. 생성

        Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
    }
    static int Sum(int i, int j)
    {
        return i + j;
    }
}
