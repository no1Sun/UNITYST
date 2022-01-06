using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//문법을 공부할 때
//응용법까지 욕심내는 경우가 있다.
//게임 프로그래밍에서는 
//실제 코드를 짜면서 보기전까지는
//응용에 대해서 느낄 수가 없다.
//프로그래밍에서는 경우가 무한대이다.
//배열이라는 것을 배웠다.
//인벤토리 만들때 쓸 수 있다.
//오브젝트를 관리할 때 쓸 수 있다.
//


//클래스의 이름들은
//전문적인 용어로 식별자
//어떠한 코드적 내용을
//묶는 하나의 명칭이다.

//프로그래머가 2명이다.
//RPG를 만들기로 했다.

//몬스터
//무기
//아이템

// A프로그래머 
//HP 포션
// B프로그래머
//MP 포션

// A프로그래머
//네임스페이스는  표현이라기 보다는 개념의 분류
namespace APRO
{
    class Potion
    {

    }
}


//식별자가 겹칠때의 문제는 사용할 때이다.
//Potion쓸게 어떤거?? HP? MP?

//B프로그래머
namespace BPRO
{
    class Potion
    {

    }
}


class Player
{ 
}



namespace _02Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
