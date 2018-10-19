// 8. 자동구현 속성 입니다.괄호를 채워주세요.

using System;

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
}
 
public class AutoImplementedCustomerManager
{
    static void Main()
    {
        Customer cust = new Customer();

        cust.ID = 1;
        cust.Name = "Amelio Rosales";

        Console.WriteLine(
            "ID: {0}, Name: {1}",
            cust.ID,
            cust.Name);

        Console.ReadKey();
    }
}

