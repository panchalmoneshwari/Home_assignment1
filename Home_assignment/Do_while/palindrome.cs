using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Do_while
{
    class palindrome
    {
        static void Main(string[] args)
        {
            int sum = 0,temp;
            Console.WriteLine("");
            int a = Convert.ToInt32(Console.ReadLine());
            temp = a;
            while (a > 0)
            {
                int r = a % 10;
                sum = (sum * 10) + r;
                a = a / 10;

            }
            if(temp==sum)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
            Console.Read();
        }
    }
}
