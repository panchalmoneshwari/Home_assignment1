using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop.Nested_for
{
    class Pattern_of_K
    {
        static void Main(string[] args)
        {
            int row = 15;
            int end = row;
            for (int r = 1; r <= row; r++)
            {
                for (int c = 1; c <= row; c++)
                {
                   // if (c==3||(r+c==6&&r>=1&&r<=3)||(r==4&&c==4)||(r==5&&c==5))
                   if(c==1||c==end)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
                if (r <= row / 2)
                {
                    end = end - 2;
                }
                else
                {
                    end = end + 2;
                }

            }
            Console.ReadLine();
        }
    }
}
