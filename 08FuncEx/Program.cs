using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{

    //맴버변수는 일반적으로 외부에서 접근하지 못하게 하는게 좋다.


    private int LV = 1;
    private int AT= 10;
    private int HP = 100;
       
    //플레이어의 레벨이 얼마인지 알고 싶다. 인자 값이 아닌 리턴값을 사용해 본다.
    //리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용한다.
    //외부에 알려줘야 하기 때문에 알려주는 순간 함수가 끝나게 된다.
    //이 Return이라는 문장을 사용하면 얼마난 많은 코드가 Return 아래에 있든 함수가 종료된다.

    public int GetLv()
    {
        return LV;
    }


    //어떤 상태가 변화하는 수간
    //각각 증가시키거나
    public void LVUP()
    {
        HP = 1000;
        AT = 100;
    }

    public void SetHP(int _HP)
    {
              
        //가장 큰 핵심은 디버깅이 된다.

        HP = _HP;
    }

    //함수는 보통 선언과 내용으로 나뉘게 되는데
    //리턴값 + 이름 + 인지값(매개변수)
    //함수란 보통 클래스 외부와의 소통을 위해서 만든다.

    public void Damage(int _Dmg)
    {
        HP = HP - _Dmg;
    }
    //두개가 될 수도 있다.
    //개수는 신경안써도 될정도로 100개 이상은 넣어줄수 있따.
    public void Damage(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }

    public int DamageToHPReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }


}


namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player();
            //

            NewPlayer.LVUP();

            NewPlayer.SetHP(1000);


            
            
            NewPlayer.Damage(10);
            NewPlayer.Damage(20);
            NewPlayer.Damage(10, 20);

            Console.WriteLine(NewPlayer.GetLv());
            Console.WriteLine(NewPlayer.DamageToHPReturn(50));
        }
    }
}
