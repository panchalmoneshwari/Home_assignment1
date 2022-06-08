using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.New_patterns
{
    class Pattern_M
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows");
            int n = Convert.ToInt32(Console.ReadLine());
            /*  ***********
             *  **********
             *  *********
             *  ********
             *  *******
             *  ******
             *  *****
             *  ****
             *  ***
             *  **
             *  *
             * */
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            /* *
             * **
             * ***
             * ****
             * *****
             * ******
             * *******
             * ********
             * *********
             * **********
             * ***********
             * */
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
