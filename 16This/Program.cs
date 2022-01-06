using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int HP = 100;

    private static int StTest = 100;

    //public void Damage(int _Dmg)
    //{

    //    //C#은 대체 어떻게 이 HP가 플레이어 2의 HP라는걸 알 수 있을까?
    //    //HP -= _Dmg;

    //    this.HP = _Dmg;
    //}

    public static void Damage(Player _this, int _Dmg)
    {
        //객체에 영향을 받지 않는 것이 정적 맴버함수 정적 맴버변수
        // HP = 1000;
        _this.HP -= _Dmg;
    }


    public static void PVP(Player _Left, Player _Right)
    {
        //객체에 영향을 받지 않는 것이 정적 맴버함수 정적 맴버변수
        // HP = 1000;
        StTest = 50;
    }

    public void Heal(int _Heal)
    {
        //맴버함수에서 맴버변수를 쓴다면 눈에 보이지 않지만 앞에 this.이 생략된 것이다.
         HP += _Heal;
    }
}

namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            Player.Damage(NewPlayer1, 100);

            Player.PVP(NewPlayer1, NewPlayer2);
        }
    }
}
