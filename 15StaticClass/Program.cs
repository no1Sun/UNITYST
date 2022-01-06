using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//정적 클래스란 정적 맴버변수와 정적 맴버함수만 가질 수 있는 클래스이다.
static class StClass
{   
    //일반 맴버변수는 선언만해도 오류가 나게 된다.
    //static int Number = 100;
}


class Player
{
    //함수의 위치는 문법적으로는 어디에 있건 상관없다.
    //구조적으로 이야기하는 것이 아니라.
    static void Main(string[] args)
    {
        Console.WriteLine("정적맴버함수");
    }
}

namespace _15StaticClass
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //}
    }
}
