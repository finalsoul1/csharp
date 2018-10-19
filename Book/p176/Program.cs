using System.Linq;
using System;

class LynqLetExample
{
    static void Main()
    {
        //문자열 입력시 콤마 다음에는 공백이 없다!
        string[] myFavor =
        {
            "Apple,Banana,Strawberry",
            "Baseball,Football,Soccur",
            "Programming,Design,Assembly",
        };
        var favorite =
            from m in myFavor
            let favor = m.Split(',')
            from word in favor
            let w = word.ToLower()
            where w[0] == 'a'
            select word;

        foreach (var w in favorite)

        {
            Console.WriteLine("A로 시작되는 단어 : {0}", w);
        }
    }
}