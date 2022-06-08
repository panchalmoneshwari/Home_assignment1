using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_assignment.Oops;

namespace Home_assignment.Inheritance
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int right,left,sum,n;
            int sq = num * num;
            int c = 0;
            n = num;
            while (n > 0)
            {
                n = n / 10;
                c++;
            }
            int Count = c;
            int r = 1;
            int temp = 1;
            while (temp <= Count)
            {
                r = r * 10;
                temp++;
            }
            int b = r;
               right = sq % b;
               left = sq / b;
            //Console.WriteLine("Right side of"+sq+"="+right);
            //Console.WriteLine("left side of"+sq+"=" +left);
            sum = right + left;
            //Console.WriteLine("sum of left and right side of square="+sum);
            if (sum == num)
                Console.WriteLine(num+" is Kaprekar number");
            else
                Console.WriteLine(num+"is not Kaprekar number");
            Console.ReadLine();
        }
    }
}
