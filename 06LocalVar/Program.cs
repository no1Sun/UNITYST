﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    //맴버변수 -> 클래스 내부에 있다고 해서 내부변수
    int Att;
    int Hp;

    void Fight()
    {
        int Damage = 0;

        Console.WriteLine("플레이어가 싸운다.");
    }
}

//게임에서 사용하기 위해서 여기까지 설계했다.

namespace _06LocalVar
{

    //C#은 고지식한 객체지향 언어
    //클래스 밖에 모르는 바보, 프로그램의 시작 조차도 클래스안에 묶어놔야 한다.
    class Program
    {

        //시작용 함수가 있다.
        static void Main(string[] args)
        {
            //클래스 안에 있으면 맴버변수
            //함수안에 있다면 지역변수
            //지역변수 규칙
            //1. 내부에서만 사용 가능한다.

            //함수 안에 있는 녀석들을 지역변수라고 한다.
            int ATT = 0;
            ATT = 50;


            //Player의 설계대로 플레이어를 만드는데 그 이름을 NewPlayer라고 해서 만든다.
            
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();



            Console.WriteLine("지역변수를 공부해 봅시다.");
        }
    }
}
