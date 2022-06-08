using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch
{
    class Harshal_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three digit number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b, c, d, e, f;
            b = a % 10;
            c = a / 10;
            d = c % 10;
            e = c / 10;
            f = b + d + e;
            if(a%f==0)
                Console.WriteLine(a+" is Harshad number");
            else
                Console.WriteLine(a+" is not Harshad number");
            Console.ReadLine();
        }
    }
}
