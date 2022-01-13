using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//객체지향 어렵지 않다.
//위에서부터 블럭이 떨어지는 것을 만들고 싶다.
enum BK
{
    W,
    V,
    B,
}

enum BLOCKTYPE
{
    BT_I,// 막대
    BT_L,//오른쪽 갈고리
    BT_J,// 왼쪽 갈고리
    BT_Z,//
    BT_S,
    BT_T,
    BT_O,//네모
    BT_MAX,
}

enum BLOCKDIR
{
    BD_T,
    BD_R,
    BD_B,
    BD_L,
    BD_MAX,
}


partial class Block
{

    int X = 0;
    int Y = 0;

    string[][] Arr = null;

    BLOCKTYPE CurBlockType = BLOCKTYPE.BT_T;
    BLOCKDIR CurDirType = BLOCKDIR.BD_T;

    TETRISSCREEN Screen = null;

    ACCSCREEN AccScreen = null;

    Random NewRandom = new Random();

    public Block(TETRISSCREEN _Screen, ACCSCREEN _AccScreen)
    {
        if (null == _Screen || null == _AccScreen)
        {
            int a = 0;
            return;
        }

        Screen = _Screen;

        AccScreen = _AccScreen;

        DataInit();

        //RandomBlockType();

        //SettingBlock(CurBlockType, CurDirType);

        Reset();

    }

    public void RandomBlockType()
    {
        //매번 생성(new)하는것 비 경제적 Random NewRandom = new Random();

        int RandomIndex = NewRandom.Next((int)BLOCKTYPE.BT_I, (int)BLOCKTYPE.BT_O);

        CurBlockType = (BLOCKTYPE)RandomIndex;
    }

    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
    }

    public void SetAccScreen()
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if ("■" == Arr[y][x])
                {
                    AccScreen.SetBlock(Y + y - 1, X + x, Arr[y][x]);
                }
               
            }
        }
    }

    public bool DownCheck()
    {
        //내가 더이상 내려갈수 없는 경우
        //1. 
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                //내가 "■" 일때
                if ("■" == Arr[y][x])
                {
                    //내가 AccScreen의 Y랑 똑같다.
                    if (AccScreen.Y == Y + y  || AccScreen.IsBlock(Y + y + 1, x + X, "■"))
                    {
                        SetAccScreen();
                        Reset();
                        return true;
                    }
                }
            }
        }
        return false;


    }
   
    public void Reset()
    {
        RandomBlockType();

        X = 0;
        Y = 1;

        SettingBlock(CurBlockType, CurDirType);
    }
    public void Down()
    {
        //내려가다가
        //아래를 확인하고
        //내려 갈수 없다면 쌓인다.
        if (true == DownCheck())
        {
            return;
        }
        //ACCSCREEN에 쌍이고
        //나를 위로 올려보내고
        //새로운 나(Block)로 바뀌어야 한다.

        Y += 1;

    }

    private void Input()
    {
        //Y += 1;

        if (false == Console.KeyAvailable)
        {
            return;
        }

        
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;

            case ConsoleKey.D:
                X += 1;
                break;

            case ConsoleKey.S:
                Down();
                //Y += 1;
                break;

            //회전 기능(정)
            case ConsoleKey.Q:
                //enum이 -- 연산이 된다.
                --CurDirType;
                if (0 > CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_L;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;

            //회전 기능 (역)
            case ConsoleKey.E:
                ++CurDirType;
                if (BLOCKDIR.BD_MAX == CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_T;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;


            default:
                break;
        }
    }

    public void Move()
    {
        Input();

        for (int y = 0; y < 4; ++y)
        {
            for (int x = 0; x < 4; ++x)
            {
                if (Arr[y][x] == "□" || Arr[y][x] == null)
                {
                    continue;
                }
                Screen.SetBlock(Y + y, X + x, Arr[y][x]);

            }
        }
    }

}
