using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop.Nested_for
{
    class Pattern_of_P
    {
        static void Main(string[] args)
        {

            for (int r = 1; r <= 7; r++)
            {
                for (int c = 1; c <= 7; c++)
                {
                    if (c == 1 || (r == 1||r==4)&&c<7||c==7&&(r>1&&r<4))
                        Console.Write("P ");
                    else
                        Console.Write("  ");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
