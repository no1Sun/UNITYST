using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//사용자 정의 자료형
interface QuestUnit
{
    //맴버변수는 넣을수 없다.
    // int A = 0;


    //함수의 형태만 물려 줄수 있는 문법
    //함수의 정의를 사용할 수 없다.
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);

}
interface QuestUnit2
{
    //맴버변수는 넣을수 없다.
    // int A = 0;


    //함수의 형태만 물려 줄수 있는 문법
    //함수의 정의를 사용할 수 없다.
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);

}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }


}

//인터페이스는 함수 구현을 강제 할 수 있다.
//인터페이스는 상속이라고 안하는 사람도 있지만, 포함의 개념이다라고 말하는 사람도 있는데
class Player : FightUnit, QuestUnit, QuestUnit2
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }

}

class NPC : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }

}

class Monster : FightUnit
{

}


namespace _31Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player();
            NPC NewNPC = new NPC();

            //실체가 없다. 함수 구현 강제만 전달한다.
            //QuestUnit questUnit = new QuestUnit();
            QuestUnit NewQuestUnit = NewNPC;

            //업캐스팅이 된다.
            NewPlayer.Talk(NewNPC);

            NewNPC.Talk(NewPlayer);


        }
    }
}
