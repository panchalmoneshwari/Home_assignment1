using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop
{
    class H_p
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the  number = ");
            int a = Convert.ToInt32(Console.ReadLine());
            int rem;
            int flage = 1;

            while (a > 0)
            {
                rem = a % 10;
                if (rem % 2 == 0)
                {
                    flage = 0;
                    break;
                }
                a = a / 10;


            }
            if (flage == 0)
            {
                Console.WriteLine("Not Happy");
            }
            else
            {
                Console.WriteLine("Happy");
            }
        }
    }
}
