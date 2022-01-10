using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //플레이어의 내부에 넣어줄 수도 있다.
    //다른곳에 정의될 수도 있다.
    public enum PLAYERJOB
    {
        NOVICE,
        KNIGHT,
        FIGHTER,
        BERSERKER,
        FIREMAGE
    }
    //직업 관련 맴버변수


    void ClassChange()
    {

    }

}

class Inven
{
    private int SelectIndex = 0;

    public void InnerClassTest()
    {
        InvenSlot NewInvenSlot = new InvenSlot();

        NewInvenSlot.Select(this);
    }

    public class InvenSlot
    {
        public void Select(Inven _inven)
        {

            _inven. SelectIndex = 10;
        }

    }

    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN
    }

    //어느 방향으로 음직이겠느냐?
    void SelectMode()
    {

    }
}


class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();

        Inven NewInven = new Inven();
        NewInven.InnerClassTest();

        Inven.INVENDIR IDIR = Inven.INVENDIR.ID_DOWN;
    }
}