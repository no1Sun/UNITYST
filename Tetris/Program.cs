﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {

            TETRISSCREEN NewSC = new TETRISSCREEN(10, 15, true);

            ACCSCREEN NewASC = new ACCSCREEN(NewSC);

            Block NewBlock = new Block(NewSC, NewASC);

            while(true)
            {
                

                for (int i = 0; i < 400000000; i++)
                {
                    int a = 0;
                }

                Console.Clear(); 
                NewSC.Render();
                NewSC.Clear();

                NewASC.Render();
                NewASC.DestroyCheck();

                NewBlock.Move();
                
            }
        }
    }
}
