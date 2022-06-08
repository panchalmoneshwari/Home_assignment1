using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop
{
    class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int m = n * i;
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}
