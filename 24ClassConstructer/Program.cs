using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FightUnit
{
    protected int AT;

    public FightUnit()
    {
        int a = 0;
    }

    //생성자 Private 접근제한 한정자

}

class Player : FightUnit
{
    
    //리턴값이 없음, 함수 이름 = 클래스 명
    public Player()
    {
        AT = 100;

        int a = 0;
    }
}


namespace _24ClassConstructer
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player();
        }
    }
}
