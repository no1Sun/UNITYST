using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected string Name = "NONE";
    protected int AT = 10;
    protected int HP = 100;


    //Overriding 문법은 
    //자식에서 부모의 함수(GETAT())를 재구현했다면, 자식의 형태의 GetAT를 호출해주세요.
    //public virtual int GetAT()
    //{
    //    Console.WriteLine("FightUnit의 GetAT");
    //    return AT;
    //}


    //프로퍼티는 Virtual된다.
    public virtual int DMGAT
    {
        get
        {
            return AT;
        }
        set
        {
            AT = value;
        }
    }



    public void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.DMGAT;

        Console.WriteLine(_OtherFightUnit.Name + "에게 " + AT + "만큼의 데미지를 입었습니다.");
        HP -= AT;
    }

    //public void Damage(Player _OtherFightUnit)
    //{

    //    Console.WriteLine(_OtherFightUnit.Name + "에게 " + _OtherFightUnit.AT + "만큼의 데미지를 입었습니다.");
    //    HP -= _OtherFightUnit.AT;
    //}

    //public void Damage(Monster _OtherFightUnit)
    //{

    //    Console.WriteLine(_OtherFightUnit.Name + "에게 " + _OtherFightUnit.AT + "만큼의 데미지를 입었습니다.");
    //    HP -= _OtherFightUnit.AT;
    //}
}

class Player : FightUnit
{
    int ItemAt = 5;


    //나는 부모님의 GetAT()를 재구현했다.
    public override int DMGAT
    {
        get{
            Console.WriteLine("플레이어의 DMGAT");
            return AT + ItemAt;
        }
        
    }
    public Player(string _Name)
    {
        Name = _Name;
    }
}

class Monster : FightUnit
{
    int MonsterLv = 2;

    public Monster(string _Name)
    {
        Name = _Name;
    }

    //나는 부모님의 GetAT()를 재구현했다.
    public override int DMGAT
    {
        get{
            Console.WriteLine("몬스터의 DMGAT");
            return AT + MonsterLv;
        }
        
    }
}

namespace _30Overraiding
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player("플레이어1");
            Monster NewMonster = new Monster("몬스터1");

           int AT = NewPlayer.DMGAT;

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
            Console.ReadKey();
        }
    }
}
