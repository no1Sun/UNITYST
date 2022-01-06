using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23inheritance
{
    //상속이란 코드 재활용성을 향상시키기 위해서 (똑같은 코드 2번 치기 싫다. 함수도 마찬가지)
    //상속을 쓰기 위해서는 A와 B가 같은 계열인가?를 파악하는 것
    // 상속 방법
    //1. 공통되는 기능을 하는 맴버변수와 맴버함수를 걷어낸다.
    //2. 새로운 클래스에 모든 맴버변수와 맴버 함수를 넣는다.


  

    //C#에서 클래스 상속이란 오직 하나만 가능하다.
    //클래스 상속을 여러개 받는 언어(C++)도 있지만, C#은 한개만 상속 받을 수 있다.

    class FightUnit
    {
        // public               클래스 외부까지
        // protected            상속된 자식까지
        // private(디폴트)       나까지(클래스 내부만)


        protected int AT = 10;
        protected int HP = 100;

        public void Damage(FightUnit _OtherUnit)
        {
            //나는 FightUnit이지만 이 함수 내부에서 플레이어의 기능을 쓰고 싶다.
            //다운캐스팅은 최대한 지양(피해라)해라.
            //플레이어를 실수로 몬스터로 변경할 수도 있다..위험!!!

            HP -= _OtherUnit.AT;
        }
    }


    class Player : FightUnit
    {
        int LV = 1; //플레이어만 레벨을 가짐. 

        void Heal()
        {
            HP = 100;
        }
    
    }
    
    class Monster : FightUnit
    {
        int Exp = 10;
    }


    //

    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();


            //플레이어의 부분을 모두 다 포기하겠다.
            //업캐스팅 : 자식이 부모형이 되는 것 -> 자식의 능력을 버린다.
            //다운캐스팅 : 부모가 
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
            //NewMonster.Damage(10);
        }
    }
}
