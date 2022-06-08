using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch
{
    class Twin_prime
    {
        static void Main(string[] args)
        {
            int a,b,flag=0;
            Console.WriteLine("enter  number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  number");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(a+" is not prime number");
                    flag = 1;
                    break;
                }
                

            }
            if (flag == 0)
            {
                Console.WriteLine(a+" is is a prime number");
            }
            for (int j = 2; j <= b / 2; j++)
            {
                if (b % j == 0)
                {
                    Console.WriteLine(b + " is not prime number");
                    flag = 1;
                    break;
                }


            }
            if (flag == 0)
            {
                Console.WriteLine(b + " is is a prime number");
            }
            Console.WriteLine();
            if(flag==0)
            {
               if( a-b==2||b-a==2)
                    Console.WriteLine(a+","+b+"are Twin Prime Number");
               else
                    Console.WriteLine(a + "," + b + "are not Twin Prime Number");
                
            }

            Console.ReadLine();
        }
    }
}
