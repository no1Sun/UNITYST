using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//정적 클래스 정적변수와 정적 함수만 내부에 가질 수 있다.
//
static class GTest
{

    //제네릭 함수,
    //맴버함수에도 통용된다.
    //자료형을 변수처럼 사용하고 싶을 때, 함수의 식별자에 <T> T: 다양한 자료형을 대표할 이름
    //제네릭
    
    
    public static T ConsolePrint<T>(T _Value)
    {
        Console.WriteLine(_Value);

        return _Value;
    }

    public static T ConsolePrint<T, U>(T _Value1, U _Value2)
    {
        Console.WriteLine(_Value1);
        Console.WriteLine(_Value2);

        return _Value1;
    }

    public static void Test(int _Number)
    {

    }

    //public static void ConsolePrint(string _Text)
    //{
    //    Console.WriteLine(_Text);
    //}

}

class CashItem
{

}

class GameItem
{

}

class Inven<T>
{
    T[] ArrInvenItem;

    public void ItemIn(T _Item)
    {

    }
    //GameItem[] ArrInvenItem;
    //CashItem[] ArrInvenItem;
}

class Program
{
    static void Main(string[] args)
    {
        GTest.ConsolePrint(100);
        GTest.ConsolePrint("하하하");
        GTest.ConsolePrint(1.3213123f);


        Inven<GameItem> NewGameItemInven = new Inven<GameItem>();
        GameItem NewGameItem = new GameItem();
        NewGameItemInven.ItemIn(NewGameItem);

        Inven<CashItem> NewCashItemInven = new Inven<CashItem>();
        CashItem NewCashITemInven = new CashItem();
        NewCashItemInven.ItemIn(NewCashITemInven);

        Console.ReadKey();
    }

}
