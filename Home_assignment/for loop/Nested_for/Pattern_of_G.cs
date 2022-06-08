using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop.Nested_for
{
    class Pattern_of_G
    {
        static void Main(string[] args)
        {

            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if ((r==5||r==1)&&(c>=2&&c<=5)||(c==1&&r>=2&&r<=4)||(c==5&&r>=3&&r<=4)||(r==3&&c>=3&&c<=5)||(r==4&&c==3))
                        Console.Write("G");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
