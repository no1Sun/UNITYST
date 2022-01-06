using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//프로그래밍에 있어서 기본기 3가지
// 디버깅 (중단점) 95%
// 문자열 3%
// 파일 입출력 2%


namespace _25String01
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열은 String으로 다룬다.
            //String은 동적 기본자료형이다.
            //

            char Charactor = 'a';

            string Test = "asdfqwerzxcvtyuighjkbnm,op[]kl;'m,./";

            //자료형은 C#에서 만들어 놓은 기본 구조체이다.
            //int는 구조체고 내부의 맴버변수나 함수가 존재하고, 이를 활용하여 문자열을 변화해 줄수 있다.

            int AAA = new int();
            AAA = 100;

            Test = AAA.ToString();


            Console.WriteLine(Test);


            string Left = "hi";
            string Right = "Nice weather";
            string Result = Left + Right + AAA.ToString();

            //자료형이 다르면 C#은 대입할 수 없다.
            if(Charactor == 'a')
            {

            }
        }
    }
}
