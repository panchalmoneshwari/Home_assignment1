using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Do_while
{
    class Simple_while_loop
    {
        static void Main(string[] args)
        {
            int i= 1;
            while (i <= 10)
            {
                Console.WriteLine(i+" ");
            }
            
            i++;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
