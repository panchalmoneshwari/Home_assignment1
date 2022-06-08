using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch.Assignment
{
    class Spy_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three digit number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b, c, d, e,f,g;
            b = a % 10;
            c = a / 10;
            d = c % 10;
            e = c / 10;
            f = b + d + e;
            g = b * d * e;
            if(f==g)
                Console.WriteLine(a+" is spy number");
            else
                Console.WriteLine(a+" is not spy number");
            Console.ReadLine();
        }
    }
}
