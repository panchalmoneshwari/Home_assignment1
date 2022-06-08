using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Oops
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public float Si(int p,float r, int t)
        {
            float si = p * r * t;
            return si;
        }
        public bool Ly(int year)
        {
            if (year % 4 == 0)
                return true;
            else

                return false; ;
        }
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Add(10, 21);
            cal.Ly(2321);
            Console.WriteLine();
               
        }

    }
}
