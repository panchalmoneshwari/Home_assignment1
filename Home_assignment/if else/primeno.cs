using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop
{
    class Primeno
    {

        static void Main(string[] args)
        {
            int n, i, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = Convert.ToInt32(Console.ReadLine());
          
            for (i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(n+" is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write(n+" is Prime.");
            Console.ReadLine();
        }
    
   
    }
}
