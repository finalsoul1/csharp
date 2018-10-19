// 3. 인덱서 오버로딩 예제 입니다.결과를 보고 코드의 괄호를 채워 주세요~

using System;

/// <summary>
///     Implements overloaded indexers.
/// </summary>
class OvrIndexer
{
    private string[] myData;
    private int arrSize;

    public OvrIndexer(int size)
    {
        arrSize = size;
        myData = new string[10];

        for (int i = 0; i < size; i++)
        {
            //myData setting
            myData[i] = "empty";
        }
    }

    public string this[int pos]
    {
        get
        {
            return myData[pos];
        }
        set
        {
            myData[pos] = value;
        }
    }

    public string this[string data]
    {
        get
        {
            int count = 0;
 
            for (int i = 0; i<arrSize; i++)
            {
                if (myData[i] == data)
                {
                    count++;
                }
            }
            return count.ToString();
        }
        set
        {
            for (int i = 0; i<arrSize; i++)
            {
                if (myData[i] == data)
                {
                    myData[i] = value;
                }
            }
        }
    }
 
    static void Main(string[] args)
{
    int size = 10;
    OvrIndexer myInd = new OvrIndexer(size);

    myInd[9] = "Some Value";
    myInd[3] = "Another Value";
    myInd[5] = "Any Value";

    myInd["empty"] = "no value";

    Console.WriteLine("\nIndexer Output\n");

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("myInd[{0}]: {1}", i, myInd[i]);
    }

    Console.WriteLine("\nNumber of \"no value\" entries: {0}", myInd["no value"]);
}
}
 
/*
[결과]
Indexer Output


myInd[0]: no value
myInd[1]: no value
myInd[2]: no value
myInd[3]: Another Value
myInd[4]: no value
myInd[5]: Any Value
myInd[6]: no value
myInd[7]: no value
myInd[8]: no value
myInd[9]: Some Value


Number of "no value" entries: 7
*/