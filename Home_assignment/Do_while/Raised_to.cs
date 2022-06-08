using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Do_while
{
    class Raised_to
    {
        static void Main(string[] args)
        {
            int result, temp;
            Console.WriteLine("");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int b = Convert.ToInt32(Console.ReadLine());

            result = 1;
            temp = 1;
            while (temp<=b)
            {
                result = result * a;
                temp++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
