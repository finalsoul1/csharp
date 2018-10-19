/*
4. 이벤트 호출시 데이터를 넘기는 예제 입니다.괄호채워 주세요
[실행결과]
iAnswer = 7
Multiple of five reached:
iAnswer = 10
*/

using System;

class Program
{
    static void Main()
    {
        Adder a = new Adder();
        //a.OnMultipleOfFiveReached += a_MultipleOfFiveReached;
        a.OnMultipleOfFiveReached += new EventHandler<MultipleOfFiveEventArgs>(a_MultipleOfFiveReached);
        int iAnswer = a.Add(4, 3);
        Console.WriteLine("iAnswer = {0}", iAnswer);
        iAnswer = a.Add(4, 6);
        Console.WriteLine("iAnswer = {0}", iAnswer);
        Console.ReadKey();
    }

    static void a_MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e)
    {
        Console.WriteLine("Multiple of five reached: {0}", e.Total);
    }
}

public class Adder
{
    public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;
    public int Add(int x, int y)
    {
        int iSum = x + y;
        if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
        {
            OnMultipleOfFiveReached(this, new MultipleOfFiveEventArgs(iSum));
        }
        return iSum;
    }
}

public class MultipleOfFiveEventArgs : System.EventArgs
{
    public MultipleOfFiveEventArgs(int iTotal)
    {
        Total = iTotal;
    }
    public int Total { get; set; }
}

