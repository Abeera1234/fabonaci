using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, trm, i, n;

            Console.Write("\n\n");
            Console.Write("Display the first n terms of fibonacci series:\n");
            Console.Write(" ");
            Console.Write("\n\n");

            Console.Write("Input number of terms to be display : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Here is the fibonacci series upto  to {0} terms : \n", n);
            Console.Write("{0}    {1}", f1, f2);

            for (i = 3; i <= n; i++)
            {
                trm = f1 + f2;
                Console.Write("  {0}  ", trm);
                f1= f2;
                f2 = trm;
            }
            Console.Write("\n");
            Console.ReadKey();
        }
      
    }
}

            