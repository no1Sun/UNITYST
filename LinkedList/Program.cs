using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Zone
{
    public string Name = "None";
    public List<Zone> LinkZone = new List<Zone>();

    public Zone(string _Name)
    {
        Name = _Name;
    }
}
class SkillInven
{

}

class ItemInven
{

}

class AllItemInven
{
    public void AllRemove()
    {

    }
}

class Node<T>
{
    public Node<T> Next;
    public Node<T> Prev;
}


class MyLinkList<T>
{
    public Node<T> First;
    public Node<T> Last;
}

class Program
{
    static void Main(string[] args)
    {
        //시퀀스 배열형  List
        //시퀀스 노드형  LinkedList

        LinkedList<int> LList = new LinkedList<int>();

        //33 22 10 11 

        LList.AddFirst(10);

        LList.AddLast(11);

        LList.AddFirst(22);

        LList.AddFirst(3);


        
        LList.RemoveFirst();
        LList.RemoveLast();


        LList.Clear();

        for (LinkedListNode<int> StartNode = LList.First ; null != StartNode.Next; StartNode = StartNode.Next)
        {
         Console.WriteLine(StartNode.Value);
        }


        //LinkedListNode<int> StartNode = LList.First;

    }
}

