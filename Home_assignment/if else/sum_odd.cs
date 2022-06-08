using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop
{
    class Sum_odd
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i += 2)
            {
                sum = sum + i;
                
            }
            Console.WriteLine("sum of frist 10 odd no.=" + sum);
            Console.ReadLine();
        }
    }
}
