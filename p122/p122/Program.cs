/*
장바구니의 구조가 다음과 같다.
CartNo 상품코드 상품명 단가 수량 합계금액
-------------------------------------------------------------
1 1001 볼펜 1000 2 2000
2 1002 연필 500 3 1500
3 1003 딸기 6000 2 12000

Cart 클래스를 구현하고, 
HashTable, Dictionary<T> 제너릭을 이용하여 장바구니를 구현해 보세요...
*/
using System;
using System.Collections;
using System.Collections.Generic;

class Goods
{
    public int goodsno { get; set; }
    public string gname { get; set; }
    public int danga { get; set; }
    public Goods(int goodsno, string gname, int danga)
    {
        this.goodsno = goodsno;
        this.gname = gname;
        this.danga = danga;
    }
    public string ToString()
    {
        return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
        + danga + "]";
    }
}
class Cart
{
    public Goods goods { get; set; }
    public int count { get; set; }
    public int sum { get { return count * goods.danga; } set { } }


    public Cart(Goods goods, int count)
    {
        this.goods = goods;
        this.count = count;
        sum = count * goods.danga;
    }
    public string ToString()
    {
        return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
        + "]";
    }
}class CartTest
{
    static void Main()
    {
        //여기를 채우세요....           
        Dictionary<int, Cart> goods = new Dictionary<int, Cart>();

        Goods pen = new Goods(1001, "볼펜", 2000);
        Goods pil = new Goods(1002, "연필", 500);
        Goods straw = new Goods(1003, "딸기", 6000);

        goods.Add(1, new Cart(pen, 2));
        goods.Add(2, new Cart(pil, 3));
        goods.Add(3, new Cart(straw, 2));

        foreach(KeyValuePair<int, Cart> i in goods)
        {
            Console.WriteLine("{0} : {1} : {2}: {3} : {4} : {5}", i.Key, i.Value.goods.goodsno,
                i.Value.goods.gname, i.Value.goods.danga, i.Value.count, i.Value.sum);
        }
    }
}

/*
[결과]
1 : 1001 : 볼펜:2000 : 2 : 4000
2 : 1002 : 연필:500 : 3 : 1500
3 : 1003 : 딸기:6000 : 2 : 12000
*/