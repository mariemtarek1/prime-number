using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter n2: ");
            int n2 = int.Parse(Console.ReadLine());
            bool prime;

            for (int i =
                
                n1; i <= n2; i++)
            {
                prime = true;
                if (i == 1)
                {
                    prime = false;
                }

                for (int j = 2; j  <= i / 2; j++)
                {
                    if (i % j == 0)

                    {
                        prime = false;
                        break;
                    }

                }

                if (prime)
                {
                    Console.WriteLine(i);
                }
            
            }
            Console.ReadKey();
        }
    }
}
