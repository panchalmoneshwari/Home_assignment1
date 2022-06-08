using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch
{
    class Factors_a
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
