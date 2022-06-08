using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch
{
    class Amicable_number
    {
        static void Main(string[] args)
        {
            int sum1 = 0, sum2 = 0, i;
            Console.WriteLine("enter frist number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <=a/2; i++)
            {
                if (a %i== 0)
                {
                    sum1 = sum1 + i;
                }
            }
            for (i = 1; i <=b/2; i++)
            {
                if (b %i == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            if (sum1==b &sum2==a)
            {
                Console.WriteLine("These are Amicable numbers");
            }
            else
            {
                Console.WriteLine("These are not Amicable numbers");
            }
            Console.ReadLine();

        }
    }
}
