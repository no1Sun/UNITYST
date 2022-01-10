using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {
                    break;
                }

                if (0 == i % 2)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            
            Console.ReadKey();
        }
    }
}
