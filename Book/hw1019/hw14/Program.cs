/*
14. 괄호를 채워주세요.

[실행결과]
Number: 10,000 
Number: 200 
Money: $ 10,000.00 
Money: $ 200.00
*/
 
using System;
class Program
{
    // declare delegate
    public delegate void Print(int value);

    static void Main(string[] args)
    {
        // Print delegate points to PrintNumber
        Print printDel = new Print(PrintNumber);

        printDel(100000);
        printDel(200);

        // Print delegate points to PrintMoney
        printDel = new Print(PrintMoney);

        printDel(10000);
        printDel(200);
    }

    public static void PrintNumber(int num)
    {
        Console.WriteLine("Number: {0,-12:N0}", num);
    }

    public static void PrintMoney(int money)
    {
        Console.WriteLine("Money: {0:C}", money);
    }
}

