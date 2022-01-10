using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//인벤토리에 담을수 있는 최대 아이템 수 정해야 한다.
//X*Y

class Inven
{
    

    private int mSelectIndex = 0;

    public int SelectIndex
    {
        get { return mSelectIndex; }
        set { mSelectIndex = value; }
    }


    Item[] ArrItem;
    int ItemX;


    public Inven(int _X, int _Y)
    {
        //
        if (_X < 1)
        {
            _X = 1;
        }
        if (_Y < 1)
        {
            _Y = 1;
        }

        ItemX = _X;

        //인벤토리(아이템 저장할 공간)를 만들었다. 아이템을 만든게 아니라.
        ArrItem = new Item[_X * _Y];
    }

    public void AddItem(Item _Item)
    {
        int Index = 0;

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (ArrItem[i] == null)
            {

                Index = i;
                break;
            }
        }
        ArrItem[Index] = _Item;
    }

    public void AddItem(Item _Item, int _Order)
    {
        if(_Order >= ArrItem.Length)
        {
            Console.WriteLine("인벤토리 저장용량보다 큽니다.");
            return;
        }

        if (null != ArrItem[_Order])
        {
            return;
        }
        ArrItem[_Order] = _Item;

    }



    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (0 != i && 0 == i % ItemX)
            {
                Console.WriteLine();
            }

            if(SelectIndex == i)
            {
                Console.Write("▣");
            }
            else if(null == ArrItem[i])
            {
                Console.Write("□");
            }
            //_X * _Y의 아이템을 가질 수 있는 인벤
           
            else
            {
                Console.Write("■");
            }
        }
        if (ArrItem[SelectIndex] != null)
        {
            Console.WriteLine("");
            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("이름 :" + ArrItem[SelectIndex].Name);
            Console.WriteLine("가격 :" + ArrItem[SelectIndex].Gold);
        }
        else
        {
            Console.WriteLine("빈공간입니다.");
           
        }
    }

    public bool OverCheck(int _SelectIndex)
    {
        
        return false;
    }

    //인자 값으로 어느 방향으로 움직였는지 주는것이 좋다.
    public void SelectMove(ConsoleKeyInfo _CKI)
    {

    }

    public void SelectMoveLeft()
    {
        int CheckIndex = SelectIndex;

        CheckIndex -= 1;

        if(true == OverCheck(CheckIndex))
        {
            return;
        }
        SelectIndex -= 1;
    }
    public void SelectMoveRight()
    {
        int CheckIndex = SelectIndex;

        CheckIndex += 1;

        if (true == OverCheck(CheckIndex))
        {
            return;
        }
        SelectIndex += 1;
    }
    public void SelectMoveUp()
    {
        int CheckIndex = SelectIndex;

        CheckIndex += ItemX;

        if (true == OverCheck(CheckIndex))
        {
            return;
        }
        SelectIndex -= ItemX;
    }
    public void SelectMoveDown()
    {
        int CheckIndex = SelectIndex;

        CheckIndex += ItemX;

        if (true == OverCheck(CheckIndex))
        {
            return;
        }
        SelectIndex += ItemX;
    }


    public void SetSelectIndex()
    {
        int initIndex = SelectIndex;

        ConsoleKeyInfo CKI = Console.ReadKey();

        switch(CKI.Key)
        {
            case ConsoleKey.LeftArrow:
                
                SelectIndex -= 1;
                if(SelectIndex < 0 )
                {
                    SelectIndex = 0;
                }
                break;

            case ConsoleKey.RightArrow:
                SelectIndex += 1;
                if (SelectIndex >= ArrItem.Length)
                {
                    SelectIndex = ArrItem.Length;
                }
                break;

            case ConsoleKey.UpArrow:
                SelectIndex += 1;
                if (SelectIndex >= ArrItem.Length)
                {
                    SelectIndex = ArrItem.Length;
                }
                break;

            case ConsoleKey.DownArrow:
                SelectIndex -= 1;
                if (SelectIndex < 0)
                {
                    SelectIndex = 0;
                }
                break;

        }

        if (ArrItem[SelectIndex] == null)
        {
            SelectIndex = initIndex;
            return;
        }
    }

}

