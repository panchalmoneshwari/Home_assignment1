using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop.Nested_for
{
    class Pattern_of_M
    {
        static void Main(string[] args)
        {

            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || c == 5||(c==r&&(c>1&&c<=3)||(c==6-r&&c>=3&&c<=5)))
                        Console.Write("M");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
