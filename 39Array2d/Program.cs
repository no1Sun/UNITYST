using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39Array2d
{
    class Program
    {
        static List<List<int>> NewArr;

        static List<int>[] ArrList;

        static int[][] Arr2dInt;
        static void Main(string[] args)
        {
            //리스트를 담을 수 있는 리스트를 만든 것
            NewArr = new List<List<int>>();

            ArrList = new List<int>[10];

            Arr2dInt = new int[10][];

            Arr2dInt[0] = new int[100];
            Arr2dInt[1] = new int[20];
        }
    }
}
