using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    //객체화 하지 않아도 플레이어의 내부는 내부이므로
    //접근제한 지정자의 영향을 받지 않는다.

    static void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }


    //static void PVE(Player _Left, Monster _Right)
    //{
    //    _Left.HP -= _Right.AT;
    //    _Right.HP -= _Left.AT;
    //}

    private int HP = 100;
    private int AT = 100;

    public void Damage()
    {
        HP -= 100;
    }


    public void Damage(Player _Other)
    {
        HP -= _Other.AT ;
    }
}

public class Monster
{
    private int AT = 100;


    //public static void PVP(Player _Left, Player _Right)
    //{   

    //    //Private는 자기 클래스 내부에서만 사용 가능
    //    //외부에서는 사용 불가능하다.
    //    _Left.HP -= _Right.AT;
    //    _Right.HP -= _Left.AT;
    //}

}



namespace _14StaticFunc
{
    class Program
    {

        //클래스에 속한 정적 함수다.
        //어떤 클래스에 존재하는 Main의 이름을 가진 정적멤버함수에서부터 C#프로그램은 시작한다.
        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine("STatic 함수 배우고 있어요");
        

            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();


            ////클래스에 속하지만 객체를 굳이 만들지 않고도 사용할 수 있는 함수를 정적맴버함수라고 한다.
            //Player.PVP(NewPlayer1, NewPlayer2);

            

            //Public인 맴버변수라도 이렇게 사용한다.
        }
    }
}
