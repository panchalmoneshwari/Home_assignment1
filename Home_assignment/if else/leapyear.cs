using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0)
                Console.WriteLine(a + "_is leap year");
            else
                Console.WriteLine(a + "_is not leap year");
            Console.ReadLine();

        }
    }
}
