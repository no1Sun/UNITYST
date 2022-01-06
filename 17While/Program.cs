using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Check = true;
            //조건문 -> 실행코드
            //실행코드
            while(Check)
            {
                Console.WriteLine("무한출력");
                Check = false;
            }

            Check = false;

            //일반적인 프로그램에서는 while문에서 항상 빠져나올 수 있는 조건을 넣어놓고 실행해줘야 한다.

            //상수를 넣어주면

            int Count = 0;

            //실행코드 -> 조건문
            while (Count < 5)
            {
                Console.WriteLine(Count);
                Count += 1;
            }
        }
    }
}
