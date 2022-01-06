using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class Program
{

    class Item
    {
        public string Name;
        public int AT;
        public int DF;
    }
    static void Main(string[] args)
    {
        //배열 기본자료형에 속한다.
        // 선언 방식 어떤 자료형[]
        //메모리가 연속되어 있고, 초기값이 "0"으로 되어있다.

        //int가 10개 생겼다.
        int[] Arrint = new int[10];

        float[] Arrfloat = new float[10];

        //C#에서 모든 자료형은 클래스 혹은 구조체에 가깝다.
        //맴버변수와 맴버함수가 있다.

        for (int i = 0; i < Arrint.Length; i++)
        {
            Console.WriteLine(Arrint[i]);
        }
        //배열 언제 사용하냐?   
        //아이템이 100개 있다.


        //아이템이라는 참조형을 담을 수 있는 공간이 10개 생겼다.
        //아이템이라는 메모리를 가리킬 수 있는 참조형이 10개 생겼다.

        Item[] ArrItem = new Item[100];

        for (int i = 0; i < ArrItem.Length ; i++)
        {
            //객체화해서 실체를 만들었다.
            ArrItem[i] = new Item();
        }

        ArrItem[0].Name = "철겁";
        ArrItem[1].Name = "전검";
        ArrItem[2].Name = "갑옷";
        ArrItem[3].Name = "갑옷2";
        ArrItem[4].Name = "포션3";

        for (int i = 0; i < ArrItem.Length; i++)
        {
            Console.WriteLine(ArrItem[i].Name);
        }

        Console.ReadKey();
    }
}
