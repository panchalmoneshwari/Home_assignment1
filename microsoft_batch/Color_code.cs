﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch
{
    class Color_code
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if (i % 3 == 0 && i% 5 == 0)
                {
                    
                    Console.WriteLine("RedBlue");

                }
                else if (i % 3 == 0)
                {
                    
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    
                    Console.WriteLine("Blue");
                }
                else
                {
                   
                    Console.WriteLine(i);
                }
                
            
            }
            Console.ReadLine();
        }
    }
}
