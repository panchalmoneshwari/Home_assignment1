using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop.Nested_for
{
    class Dofor
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }

    }
}
