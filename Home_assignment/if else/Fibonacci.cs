using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.for_loop
{
    class Class1
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, num;
            
            
            Console.Write("Enter the number of elements: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1  
            
            for (i = 2; i < num; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }

    }
}
