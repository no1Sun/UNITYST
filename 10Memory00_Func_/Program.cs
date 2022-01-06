using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//메모리
//모든 프로그램의 근간이 되는 개념이기 때문입니다.
//모든 프로그램은 공짜가 없다. 메모리를 지불한다. 메모리의 구조를 아는것은 코드의 동작원리를 아는것 과 같다.

class Player
{
    int HP = 100;
    int AT = 10;
    public void Test(int _Dmg)
    {
        _Dmg = 1000;
    }


}


class Program
{
    static void Main(string[] args)
    {
        int Value = 0;
        Player NewPlayer = new Player();

        NewPlayer.Test(Value);
    }
}