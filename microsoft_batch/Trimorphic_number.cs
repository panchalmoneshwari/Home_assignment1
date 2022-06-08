using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch
{
    class Trimorphic_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a * a * a;
            int c = b % 10;
            if (a == c)
                Console.WriteLine("This is Trimorphonic number");
            else
                Console.WriteLine("This is not Trimorphonic number");
            Console.ReadLine();
        }
    }
}
