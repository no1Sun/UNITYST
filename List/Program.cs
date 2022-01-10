using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Item
{

}


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열형
            //시퀀스

            //

            //List는 내가 만든게 아니다. 

            List<int> NewListint = new List<int>();

            Console.WriteLine("Capacity " + NewListint.Capacity);
            Console.WriteLine("Count " + NewListint.Count);


            NewListint.Add(100);

            Console.WriteLine("Capacity " + NewListint.Capacity);
            Console.WriteLine("Count " + NewListint.Count);


            NewListint.Add(1);

            Console.WriteLine("Capacity " + NewListint.Capacity);
            Console.WriteLine("Count " + NewListint.Count);


            NewListint.Add(2);

            Console.WriteLine("Capacity " + NewListint.Capacity);
            Console.WriteLine("Count " + NewListint.Count);


            NewListint.Add(3);

            Console.WriteLine("Capacity " + NewListint.Capacity);
            Console.WriteLine("Count " + NewListint.Count);



            NewListint.Add(4);


            Console.WriteLine("Capacity " + NewListint.Capacity);
            Console.WriteLine("Count " + NewListint.Count);

            List<Item> NewList = new List<Item>();

            Item NewItem = new Item();

            NewList.Add(NewItem);

            Console.ReadKey();
            
        }
    }
}
