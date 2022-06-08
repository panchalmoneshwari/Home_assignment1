using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch
{
    class Even_square
    {
        static void Main(string[] args)
        {
            int a=0,b;
            while(a<=50)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    b = a * a;
                    Console.WriteLine(b);
                }
                a++;
            }
            
            Console.ReadLine();
        }
    }
}
