using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//내가 만들거나 만들지 않은 모든 인터페이스란 내가 가용 할 수 있는 코드를 말한다.

//어떻게 설계해야 하느냐는 각자의 선택에 따라 다르다.

class Program
{
    static void Main(string[] args)
    {
        //*****
        //*****
        //*****

        Inven NewInven = new Inven(5, 3);
        Item NewItem = new Item("FireSword", 100);


        NewInven.AddItem(new Item("아이템1", 1000));
        NewInven.AddItem(new Item("검", 1000));
        NewInven.AddItem(new Item("물약", 1000));
        NewInven.AddItem(new Item("아이템 7", 1000), 7);


        //NewInven.AddItem(new Item("검", 1000), 21);


        //객체간의 구조를 만들때 규칙이 있다.
        //SOLID
        //SRP(Single Responsibility Principle): 단일 책임 원칙
        //OCP(Open Closed Priciple): 개방 폐쇄 원칙
        //LSP(Listov Substitution Priciple): 리스코프 치환 원칙
        //ISP(Interface Segregation Principle): 인터페이스 분리 원칙
        //함수를 잘깨쪼개서 만든다음 그 함수들을 조합해서 새 기능을 만들어 내라.
        //DIP(Dependency Inversion Principle): 의존 역전 원칙


        while (true)
        {
            Console.Clear();


            NewInven.Render();

            ConsoleKeyInfo CheckKey = Console.ReadKey();

            switch (CheckKey.Key)
            {
                case ConsoleKey.LeftArrow:
                    NewInven.SelectMoveLeft();
                    break;

                case ConsoleKey.RightArrow:
                    NewInven.SelectMoveRight();
                    break;

                case ConsoleKey.UpArrow:
                    NewInven.SelectMoveUp();
                    break;

                case ConsoleKey.DownArrow:
                    NewInven.SelectMoveDown();
                    break;

            }

            NewInven.SetSelectIndex();
            Console.ReadKey();
        }

    }
}
