using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop
{
    class Fact
    {
        static void Main(string[] args)
        {
            int fct = 1;

            for (int i = 1; i <= 10; i = i + 1)
            {
                fct = fct * i;
               // Console.WriteLine(fct);
            }
            Console.WriteLine(fct);
            Console.ReadLine();
        }
    }
    
}
