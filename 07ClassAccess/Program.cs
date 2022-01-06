using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 객체지향 프로그래밍에서는 가장 처음으로 해야 할 일이 내가 RPG 뭘 만들고 싶다.
//클래스를 선언한다.
//class Dragon
//{
//    int AT; //맴버변수
//    int HP;   //맴버변수
      //void Damage()
      //{
      //  HP = HP - 10;
      //}
//}


class Player
{
    //클래스의 내부 -> 
    //객체지향의 캡슐화 은닉화를 대표하는 문법
    //접근 제한 지정자입니다.

    //맴버변수 -> 클래스 내부에 있다고 해서 내부변수
    public int HP; //외부에 공개
    protected int ATT; //자식에게만 공개
    private int DEF; //내부에만 공개


    public void Fight()
    {
        Console.WriteLine("플레이어가 싸운다.");
    }
}//클래스의 끝

//클래스의 외부



namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player();

            //만들어진 객체의 내용을 사용하기 위해서는 객채의 이름.을 사용한다.
            //접근제한 지정자라는 문법을 사용하지 않아서 클래스 외부에 공개 되지 않는다.

            NewPlayer.HP = 0;

            NewPlayer.Fight();
        }
    }
}
