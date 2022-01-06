using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int AT = 10;

    public int ProAT
    {
        get
        {
            return AT;
        }
        set
        {
            AT = value;
        }
    }

    public static int m_StaticValue = 100;
    public static int StaticValue
    {
        get
        {
            return m_StaticValue;
        }
        set
        {
            m_StaticValue = value;
        }
    }
        


    public int GetAT()
    {
        if (999 < AT)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true)
            {
                Console.ReadLine();
            }
        }

        return AT; 
    }

    public void SetAT(int _Value)
    {
        if(999 < _Value)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while(true) { Console.ReadLine(); }
        }
        AT = _Value;
    }

    
}



namespace _26Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            NewPlayer.ProAT = 1000;

            Player.StaticValue = 200;

            NewPlayer.SetAT(1000);
        }
    }
}
  