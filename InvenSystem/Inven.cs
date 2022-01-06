using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//인벤토리에 담을수 있는 최대 아이템 수 정해야 한다.
//X*Y

class Inven
{
    
    Item[] ArrItem;

    public Inven(int _X, int _Y)
    {
        //
        if(_X < 1)
        {
            _X = 1;
        }
        if (_Y < 1)
        {
            _Y = 1;
        }

        ArrItem = new Item();
    }
}

