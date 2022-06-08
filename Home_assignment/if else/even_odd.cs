using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.if_else
{
    class even_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
                Console.WriteLine(a+"_is even");
            else
                Console.WriteLine(a+"_is odd");
            Console.ReadLine();

        }
    }
}
