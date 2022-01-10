using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//그냥 쓰는것 보다 어떤 클래스로 감싸서 사용한다.

class DicTest
{
   private Dictionary<string, int> NewDic = new Dictionary<string, int>();

    public void Print(string _Name)
    {

        if(false == NewDic.ContainsKey(_Name))
        {
            return;
        }
        if (true == NewDic.ContainsKey(_Name))
        {
            Console.WriteLine(NewDic[_Name]);
        }


    }
    public void Add(string _Name, int Value)
    {
        if(!NewDic.ContainsKey(_Name))
        {
            NewDic.Add(_Name, Value);
        }
    }
}



namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //연관 배열
            //string Key, int Value
            //자신이 감싼다.
            //Dictionary<string, int> NewDic = new Dictionary<string, int>();
            
            //if(false == NewDic.ContainsKey("일이에요"))
            //{
            //    NewDic.Add("일이에요", 1);
            //}

            
            //NewDic.Add("이에요", 2);
            //NewDic.Add("뭘까요?", 3);

            //NewDic.Add("재밌따?", 4812);

            DicTest NewTest = new DicTest();
            NewTest.Add("하하하", 1);
            NewTest.Add("하하하1", 21);
            NewTest.Add("키입니다", 1);


            NewTest.Print("하하하1");
            NewTest.Print("키입니다");



            //NewDic.Remove("재밌따?");

            //string Key = "당연히 없는 값 테스트용";

            //if(true == NewDic.ContainsKey(Key))
            //{
            //    Console.WriteLine(NewDic["일이에요"]);
            //}


            //Console.WriteLine(NewDic["일이에요"]);



        }
    }
}
