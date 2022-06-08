using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsoft_batch
{
    class IMEI
    {
        static void Main(string[] args)
        {
            long number = 0, count = 0;

            Console.Write("Enter number :");
            number = Convert.ToInt64(Console.ReadLine());
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            //Console.WriteLine("Number of digits is : " + count);
            if (count == 15)
            {
                int sum = 0;
                for(int i=1;i<=15;i++)
                {
                    int b = (int)(number % 10);
                    if (i % 2 == 0)
                    {
                        int db = 2 * b;
                        if (db < 9)
                            sum = sum + db;
                        else
                            sum = sum + db % 10 + db / 10;

                    }
                    else
                    {
                        sum = sum + b;
                    }

                }
                if(sum==0)
                    Console.WriteLine("Valid IMEI number");
                else
                    Console.WriteLine("please,enter valid IMEI number");
                
            }
            
            else
            {
                Console.WriteLine("Please,Enter 15 digit number");
            }
           


            Console.ReadLine();
        }
    }
}
