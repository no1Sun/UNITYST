using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//기본 자료형 -> 이미 있다.


//사용자 정의자료형 중 하나
//class 참조형 사용자 정의
//struct 값형 사용자 정의
//enum 값형 사용자 정의

//다른 언어에서는 정수형 상수라고하는데 C#에서는 아니다.
//보통 어떤 상태를 표현하는 것 중 나만의 것을 가지고 싶을때 사용한다.
//열거형, 값형


//값형이다, int라고 생각해도 된다. 사용방법 제외하고는 int랑 같이 사용된다고 생각하면 된다.
//내가 값의 범위를 지정한 새로운 자료형을 만들어 낼 수 있다는 장점이 있고, Switch문과 궁합이 좋다.
enum ITEMTYPE
{
    EQUIP = 0,
    POTION,
    QUEST, 
    NONESELECT
}


class ITEM
{
    public ITEMTYPE ItemType = ITEMTYPE.NONESELECT;    
    
    public void PotionTypeSetting()
    {
        ItemType = ITEMTYPE.POTION;
    }

}


enum PLAYERJOB
{

}

namespace _22Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            ITEM NewItem = new ITEM();
            NewItem.ItemType = ITEMTYPE.POTION;
            NewItem.PotionTypeSetting();

            Console.WriteLine(NewItem.ItemType);

            //값
            ITEMTYPE Type = ITEMTYPE.POTION;

            switch (Type)
            {
                case ITEMTYPE.EQUIP:
                    break;
                case ITEMTYPE.POTION:
                    break;
                case ITEMTYPE.QUEST:
                    break;
                case ITEMTYPE.NONESELECT:
                    break;
                default:
                    break;
            }

        }
    }
}
