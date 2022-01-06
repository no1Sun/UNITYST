using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    private int HP = 100;

    void Damage(int _HP)
    {
        HP = HP - 10;
    }

    bool ReturnTrur()
    {
        return true;
    }

    public int Plus(int _Left, int _Right)
    {
        int Result = _Left + _Right;
        return Result;
    }
}


namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            
        int Result = 0;
            int Left = 7;
            int Right = 3;


            //산술연산자

            Result = NewPlayer.Plus(Left, Right);

            Result = Left + Right;
            Result = Left - Right;
            Result = Left * Right;
            Result = Left / Right;
            Result = Left % Right;


            //비교연산자

            int Number = -36778921;

            bool BResult = true;
            BResult = false;

            BResult = Left > Right;
            BResult = Left < Right;
            BResult = Left <= Right;
            BResult = Left >= Right;
            BResult = Left == Right;
            BResult = Left != Right;


            //bool 논리 연산자

            BResult = true && false; //and 
            BResult = true || false;    // OR
            BResult = true ^ false;     //XOR
            BResult = !false;            //NOT
            BResult = !true;            //NOT

        }
    }
}

