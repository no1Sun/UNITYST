using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//값형이다.
struct StructData
{
    //클래스와 비슷한데 안되는 것이 있다.
    // =0 안된다.

    public int a ;
    public int b ;

    public void Func()
    {
        a = 100;
        b = 100;
    }
}

namespace _21Struct
{
    class Program
    {
        static void Test(StructData _Data)    
        {
            _Data.a = 1000;
        }

        static void TestNumber(int _Number)
        {
            _Number = 1000;
        }


        static void Main(string[] args)
        {

            //지역변수 Number - 스택 영역
            int Number = 100;


            //
            StructData NewData = new StructData();
            //이게 될텐데? 왜 안돼?
            //안되면 아 정말... 이런것도 안되게 하고..
            //그러면 그 언어를 쓰지마~!ㅋㅋ
            //
            
            NewData.a = 10;
            NewData.b = 10;

            //참조형과 값형이 있따.
            //클래스를 객체화하면 그건 참조형이다.

            //Struct는 값형이다.             

            Test(NewData);
        }
    }
}
