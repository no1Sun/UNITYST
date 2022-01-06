using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//초반에 프로그래밍의 전부
//객체(클래스)를 선언해야 할때
//맴버변수
//함수의 분기
//함수의 통합




//클래스는 자기의 일은 스스로 하자 => 캡슐화

class FightUnit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int m_MAXHP = 100;


    public int MAXHP
    {
        get
        {
            return m_MAXHP;
        }
        set
        {
            m_MAXHP = value;
        }
    }

    public bool IsDeath()
    {
        
        //bool boolDeath = HP <= 0;
        //return boolDeath;

        //bool boolDeath = HP <= 0;
        return HP <= 0;
    }

    public void StatusRender()
    {
        Console.Write(Name);
        Console.WriteLine("의 능력치-------------------------------------------");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);

        //체력 50/100
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");

        Console.WriteLine(m_MAXHP);
        Console.WriteLine("-------------------------------------------");
    }

    public void SetName(string _Name)
    {
        Name = _Name;
    }

    public void Damage(FightUnit _fightunit)
    {
        if (HP <= 0)
        {
            Console.WriteLine(Name + " 는 사망하였습니다.");
        }
        else
        {
            HP -= _fightunit.AT;
            Console.WriteLine(Name + " 가 " + _fightunit.Name + "으로부터 공격을 받았습니다.");
            PrintHP();
        }
    }

    public void PrintHP()
    {
        Console.WriteLine(this.Name + "의 HP : " + this.HP + "입니다.");
    }

    public void PrintAT()
    {
        Console.WriteLine(this.Name + "의 AT : " + this.AT + "입니다.");

    }

    public void UpgradeAT()
    {
        AT += 10;
        GetAT();
    }

    public int GetAT()
    {
        return AT;
    }

    public int GetHP()
    {
        if (HP <= 0)
        {
            Console.WriteLine(Name + " 는 사망하였습니다.");
        }
        else
        {
            PrintHP();
        }
        return HP;
    }

}


class Player : FightUnit
{
    //코드 재활용성이 떨어진다.
    //코드 재활용성 향상 시키기 위한 문법이 상속이다.
    
    public Player()
    {
        Name = "플레이어";
    }

    //플레이어만 가지는 기능
    public void MaxHeal()
    {
    //함수는 작을수록 좋다.
    //5~10줄짜리 함수를 만든다.
        if (HP >= m_MAXHP)
        {
            Console.WriteLine("");
            Console.WriteLine("HP가 최대값입니다. 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            this.HP = m_MAXHP;
            PrintHP();
        }
        return;
    }

   

}

class Monster : FightUnit
{
    //생성자에 인자값을 만들어 줄 수도 있다.
    public Monster(string _Name)
    {
        Name = _Name;
    }
}


//에러나 혹은 잘못된 선택에 관한것도 만든다.
enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT,
}

namespace TextRpg001
{



    class Program
    {
        //시한다.
        static STARTSELECT StartSelect()
        {
            Console.Clear();

            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 갈래?");


            ConsoleKeyInfo CKI = Console.ReadKey();

            Console.WriteLine("");

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;

                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;

                default:
                    Console.WriteLine("잘못된 선택을 했습니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }

        static STARTSELECT Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();

                _Player.StatusRender();


                Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
                Console.WriteLine("1. 체력 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.MaxHeal();
                        Console.ReadKey();

                        break;
                    case ConsoleKey.D2:
                        _Player.UpgradeAT();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("3. 마을 나감");
                        return STARTSELECT.NONESELECT;
                }
            }
        }


        static STARTSELECT Battle(Player _player)
        {
            Monster NewMonster = new Monster("오크");




            while (/*둘중 누군가 죽을때까지*/!_player.IsDeath() && !NewMonster.IsDeath())
            {
                //가장 기본적인것이 되면 그다음부터 해라
                //1. 죽을때까지 싸우게 만들어라.
                //2. 한쪽이 죽으면 마을로 자동이송

                Console.Clear();
                _player.StatusRender();
                NewMonster.StatusRender();
                Console.ReadKey();


                NewMonster.Damage(_player);

                if (!NewMonster.IsDeath())
                {
                    _player.Damage(NewMonster);
                }
            }


            Console.WriteLine("싸움이 결판이 났습니다.");

            if(NewMonster.IsDeath())
            {
                Console.WriteLine("플레이어의 승리입니다.");
            }
            else
            {
                Console.WriteLine("몬스터의의 승리입니다.");
            }

            Console.ReadKey();
            return STARTSELECT.SELECTTOWN;
            //Town(_player);


        }


        static void Main(string[] args)
        {

            //저는 마을과 싸움터로 나눠서 어디로 갈지 정하고 싶어요
            //반복문과 조건문중 어떤거? -> 조건문

            //초기 선택
            // 1. 마을로 간다.
            // 2. 싸움터로 간다.

            // 마을의 내용
            //마을에 도착했습니다.

            //1. 여관에 들른다.
            //2. 공격력을 강화한다.
            //3. 나간다.

            // 싸움터 내용
            //싸움터에 도착했습니다.
            //몬스터가 등장했다.
            //싸우는데 나간다.
            //1 데미지를 입혔다. xx는 2의 HP가 남았다.

            //Switch 문

            //while(true)
            //{   
            //    //정적맴버함수, Static함수
            //    ConsoleKeyInfo KeyInfo = Console.ReadKey();

            //    Console.WriteLine(KeyInfo.Key);


            //}

            //객체지행프로그래밍이란 클래스 설계하고 객체로 만들어 가는것

            //첫번째 static
            // 
            STARTSELECT SelectCheck = STARTSELECT.NONESELECT;
            Player NewPlayer = new Player();

            while (true)
            {
                //함수 자체의 용도를 생각해라
                //정말 한가지의 용도로만 사용할 수 있나?
                
                
                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = Battle(NewPlayer);
                        break;
                }
            }
        }
    }
}