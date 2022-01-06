using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Player
{
    //Static 정적 맴버변수
    //일반 맴버변수와 다르게 객체활르 하지 않고도 사용할 수 있다.

    public static int PlayerCount = 0;

    public int AT = 10;
    public int HP = 100;

    public void Setting(int _AT, int _HP)
    {
        AT = _AT;
        HP = _HP;
    }
}


class Monster
{
   static int MonsterDeathCount;

    public void Death()
    {
        MonsterDeathCount += 1;
    }
}


namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;

            //정적 맴버변수는 데이터 영역에 들어가게 된다.

            //정적맴버는 객체 내부에서 사용할 수 있다뿐이지 객체의 개수만큼 만들어지는 것은 아니다.
            //즉, 모든 객체가 공유하는 하나의 변수가 되어진다.

            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 15);
            NewPlayer3.Setting(100, 500);


            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();


            //모든 객체가 값을 공유할 필요가 있는 데이터를 정의하는데 사용한다.
            
            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();


        }
    }
}
