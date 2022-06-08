using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop.Nested_for
{
    class Pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter row");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter columns");
            int b = Convert.ToInt32(Console.ReadLine());
            
    for(int r=1;r<=a;r++)
            {
                for (int c = 1; c <= b; c++)
                {
                         Console.Write(".");
                   
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
