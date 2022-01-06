using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    public int HP = 100;
    public int AT = 10;

   
    //Monster _Monster 클래스가 객체화된 녀석을 받았다.
    public void ATT(Monster _monster)
    {
        _monster.HP -= AT;
    }

    public void TEST(int _Test)
    {
        _Test=1000;
    }


}



class Monster
{
    public int HP = 100;
    public int AT = 10;


    public void ATT(Player _player)
    {
        //100 -= 10
        _player.HP -= AT;
        // = 90
    }


}



namespace _12Memory02_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            //값형과 레퍼런스 형 구분
            //기본자료형을 선언만 하면 값형
            //자기가 만들 클래스를 new 클래스명()해서 만든것을 그 클래스명에 받으면 레퍼런스 형



            //클래스가 객체화된 것은 레퍼런스 형이라고 하는 자료형이 되고
            //int, bool 이런 것들은 값형이라고 한다.
            //값형과 레퍼런스형은 메모리의 위치와 사용법이 다르기 때문에 다르게 동작한다.


            //레퍼런스라고하는 것은 힙에 생성된 어떠한 메모리의 위치를 가리키는 값이다.
            //new xxx()는 힙영역에 생긴다. 실제 만들어진다.
            
            Monster NewMonster = new Monster();

            Player NewPlayer = new Player();
            //얕은 이해.

            //안에 값을 끌어내고 싶으면 . 누르면 끌어진다.
            //내가 가리키고 있는 위치에 잇는 HP를 사용하겠다.
            //NewPlayer라는 것은

            // 
            NewMonster.ATT(NewPlayer);


            NewPlayer.ATT(NewMonster);






            //int Value = 100;

            //NewPlayer.TEST(Value);
            //플레이어의 HP가 변경된 것이 보인다.

        }
    }
}


