using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop
{
    class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(n%i==0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
