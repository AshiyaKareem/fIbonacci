using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Convert.ToInt32(Console.ReadLine());
            //int[] fib = new int[20];
            int a = 0;
            int b = 1;
            int sum = 0;

            for(int i=0;i<limit;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    if (i == 0)
                    {
                        Console.Write(1);
                        break;
                    }
                    else
                    {
                        sum = a + b;
                        Console.Write(sum+" ");
                        a = b;
                        b = sum;
                    }
                   

                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
//6
//1
//1 2
//3 5 8
//13 21 34 55
//89 144 233 377 610
//987 1597 2584 4181 6765 10946
