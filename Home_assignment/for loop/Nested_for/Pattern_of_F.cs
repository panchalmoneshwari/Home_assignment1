﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop.Nested_for
{
    class Pattern_of_F
    {
        static void Main(string[] args)
        {

            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || (r == 3&&c>=1&&c<=3) || c == 1)
                        Console.Write("F");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}