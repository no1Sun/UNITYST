using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자료 구조를 만들어 보는건 프로그래머의 기본 소양
//자료구조에 대해서 알아보자.
//총알이 1000발 발사된다. 어떻게 관리하지?
//NPC가 500명이 있다. 그중에서 "피오나"라는 이름의 NPC가 있는데, 어떻게 찾지?

class MyDataStruct<T>
{
    //자료를 넣는다.()
    //탐색()
    //확장한다.()

    public void Push(T _Data)
    {
        if(true)
        {
            //Ex();
        }
    }

    public void Find(T _Data)
    {

    }

    public void Ex(int _Size)
    {

    }
}

namespace _38DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[10]
            // 0 1 2 3 4 5 6 7 8 9 

            //자료 구조에는 다음의 구조나 인터페이스를 지원한다.
            //함수로 표현한다.
            //자료를 넣는다.()
            //탐색()
            //확장한다.()
            

            //자료 구조에는 보통 컨테이너라는 용어 사용
            // 시퀀스 컨테이너 List
            // 연관 컨테이너  Dictionary
            // 어뎁터 컨테이너 Stack Queue

            //데이터의 메모리 구조는 배열과 노드형




            int[] Arr = new int[10];

            int[] Arr2 = new int[15];

            MyDataStruct<int> MDS = new MyDataStruct<int>();

            MDS.Push(100);

            MDS.Find(50);

            MDS.Ex(50000);


            Arr[0] = 0;
            Arr[1] = 1;
        }
    }
}
