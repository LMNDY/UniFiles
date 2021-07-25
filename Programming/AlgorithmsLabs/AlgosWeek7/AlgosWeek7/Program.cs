using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosWeek7
{
    class Program
    {
        static int Power(int x, int y)
        {
           
            if (y > 0)
            {
                x *= Power(x, dec(y));
                return x;
            }
            
            
            else return 1;
            
        }

        static int inc(int x)
        {
            return x + 1;
        }

        static int dec(int x)
        {
            return x - 1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(" 2^5 = " + Power(2, 5));
            Console.WriteLine(" 3^5 = " + Power(3, 5));
            Console.WriteLine(" 4^5 = " + Power(4, 5));
            Console.WriteLine(" 5^5 = " + Power(5, 5));
            Console.WriteLine(" 6^5 = " + Power(6, 5));
            Console.WriteLine(" 7^5 = " + Power(7, 5));

            Console.ReadLine();
        }

    }
}
