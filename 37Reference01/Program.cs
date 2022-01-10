using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    public int HP = 100;
    public int AT = 10;

    public bool IsDeath()
    {
        Console.WriteLine("이 플레이어의 생존 유무 확인 함수입니다.");
        return HP <= 0;
    }

    public void TEstFunc(Player _player)
    {
        TEstFunPart1(_player);
    }

    public void TEstFunPart1(Player _player)
    {
        TEstFuncPart2(_player);
    }

    public void TEstFuncPart2(Player _player)
    {
        _player.AT = 20;
    }
}

namespace _37Reference01
{
    

    class Program
    {
        static int Number = 100;

        static void ArrTest(int[] _ArrTest)
        {
            _ArrTest[0] = 99999;
        }
        static void PlayerTest(Player _Test)
        {
            _Test.AT = 10000;    
        }

        static void ClassTest(Player _Test)
        {
            Console.WriteLine("공력력을 테스트 해볼까요?");
            
            _Test.AT = 10000;
        }

        static void Main(string[] args)
        {
            //NewPlayer 이 볜수는 할 수 있는 일이 어떤 녀석을 가리키는 일밖에 하지 못한다.
            //다른 녀석을 가리킬 수 있다.

            //new Player() 
            Player NewPlayer = new Player();

            NewPlayer.AT = 50;

            NewPlayer.TEstFunc(null);

            Player NewPlayer2 = NewPlayer;
            //같은 것을 2개가 가리키고 있다.
            NewPlayer2.AT = 999;
             
            ClassTest(NewPlayer);

            int[] ArrNumber = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ArrTest(ArrNumber);

            //ArrTest(null);
            Player NewPlayer3 = null;
            NewPlayer3.IsDeath();
        }
    }
}
