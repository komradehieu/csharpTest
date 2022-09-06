using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsoleApp
{
    internal class Class1
    {
        public static void testStar()
        {
            int i, j, k;

            for (i = 0; i < 10; i++)
            {
                for (k = 0; k < 10 - i; k++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
