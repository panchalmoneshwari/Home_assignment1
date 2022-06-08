using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.New_patterns
{
    class Practice1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows");
            int n = Convert.ToInt32(Console.ReadLine());
            
            /*
              1
              A B
              1 2 3
              A B C D
              1 2 3 4 5
              */

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if(i%2==1)
                    Console.Write(j+ " ");
                    else
                        Console.Write((char)(64+j)+" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                        Console.Write("# ");
                    else
                        Console.Write("@ ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();
        }
    }
}
