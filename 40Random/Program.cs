using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Random
{
    class Program
    {
        static int PrevValue = 123458;

        static int Func()
        {
            int X = 0;

            X += PrevValue;



            return X;
        }
        //난수의 환상
        //프로그래밍에서 난수란 존재하지 않는다. 
        static void Main(string[] args)
        {
            Random NewRandom = new Random();

            while (true)
            {
                int Random = NewRandom.Next(0, 7);
            }
        }
    }
}
