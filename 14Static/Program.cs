using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SideMonster
{

    public int X = 0;
    public int Y = 0;
    public int HP = 0;

    public void Gravity()
    {
        Y -= 200;
    }
}



class SidePlayer
{
    //정적 맴버변수
    //객체에 귀속된것이 아니라, 클래스 그 자체에 귀속되고, 데이터 영역에 메모리가 올라간다.
    static public int PlayerCount;
    //Static 붙지 않은 맴버변수들은 개체 하나하나가 자신의 것을 가진다.

    public int X = 0;
    public int Y = 0;
    public int HP = 0;

   
}




namespace _14Static
{
    class Program
    {
        static void Main(string[] args)
        {
            SidePlayer.PlayerCount = 3;    

            //프로그램내에서 하나만 존재하며, 일반적으로 클래스내부에서 모든 객체가 공유하고 싶은
            //변수를 만들때 사용한다. 
            SidePlayer NewPlayer1 = new SidePlayer();
            SidePlayer NewPlayer2 = new SidePlayer();
            SidePlayer NewPlayer3 = new SidePlayer();

            SidePlayer NewPlayer = new SidePlayer();
        }
    }
}
