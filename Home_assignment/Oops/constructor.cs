using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Oops
{
    class Constructor
    {
        public int Sq(int x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            Constructor c = new Constructor();
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = c.Sq(n);
            Console.WriteLine(c.Sq(result));
        }

    }
}
