using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop
{
    class Shape_pattern_
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows");
            int n = Convert.ToInt32(Console.ReadLine());
            /* 5
             * 45
             * 345
             * 2345
             * 12345
             * */
            for (int i=n;i>=1;i--)
            {
                for (int j = i; j <= n  ; j++)
                {
                    Console.Write(j+" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");

            /*
             * ABCDE
             * BCDE
             * CDE
             * DE
             * E
             * */
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = i; j <= 'E'; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");

            /* A
             * A A
             * A   A
             * A     A
             * A A A A A
             * */
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    if (j == 1 || i == n || i == j)
                        Console.Write("A ");
                    else
                        Console.Write("  ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");

            /* 5
             * 4  5
             * 3    5
             * 2      5
             * 1  2 3 4 5
             */

               
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i ; space++)
            {
                Console.Write(" ");
            }
                for (int j = 1; j <= (2*i-1); j++)
                {
                if (i < n)
                {

                    if (j == i || j == 2 * i - 1)
                    {
                        Console.Write("*");
                    }

                    else
                        Console.Write("  ");
                }
                else
                    Console.Write("*");
                } Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            /* E E E E E 
             * D D D D 
             * C C C  
             * B B
             * A
             */
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = i;j>= 'A'; j--)
                {
                    Console.Write(i+ " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");

            /* 1
             * 2 2
             * 3 3 3
             * 4 4 4 4
             * 5 5 5 5 5
             * */
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");

            /* 1 1 1 1 1 
             * 2 2 2 2
             * 3 3 3
             * 4 4
             * 5
             * */
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            /* 1
             * 1 2
             * 1 2 3
             * 1 2 3 4 
             * 1 2 3 4 5
             * */
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            /*         1
             *       1 2
             *     1 2 3
             *   1 2 3 4
             * 1 2 3 4 5
             * */
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            /*
             * 1 2 3 4 5
             *   1 2 3 4
             *     1 2 3
             *       1 2
             *         1
             * */
            for (int i = n; i >= 1; i--)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            /*1 2 3 4 5
             * 1 2 3 4
             *  1 2 3
             *   1 2
             *    1
             * */
            for (int i = n; i >= 1; i--)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");

            /*        1
             *       1 2
             *      1 2 3
             *     1 2 3 4
             *    1 2 3 4 5 
             * 
             * */

            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");

            /* *
             * * *
             * * * *
             * * * * *
             *** * * * *
             */
            

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            /*           *
                       * *
                     * * *
                   * * * *
                 * * * * *
             * */
            for (int  i=1;i<=n;i++)
            {
                for (int space=1;space<=n-i;space++)
                {
                    Console.Write("  ");
                }
                for (int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            /* 1 3 5 7
             * 3 5 7
             * 5 7
             * 7
             * */

            for (int i = 1; i <= 7; i=i+2)
            {
                for (int j = i; j <= 7; j = j + 2)
                {
                    Console.Write(j +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");

            /* 1
             * 1 3 
             * 1 3 5
             * 1 3 5 7
             * 
             * */
            for (int i = 1; i <= 7; i = i + 2)
            {
                for (int j = 1; j <= i; j = j + 2)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            /*               *
             *             *   *
             *           *   *   *
             *          *  *   *   *
             *               .
             *               .
             *               .
             * */


            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if(j==1||j==n||i==n)
                    Console.Write("*"+" ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n-1; i >= 1; i--)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2*i - 1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

           
            
        
    }
    
}
