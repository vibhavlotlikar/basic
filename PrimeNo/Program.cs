using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  the number");
            int n = Convert.ToInt32(Console.ReadLine());


            //int count = 0;
            //for (int i = 1; i <=n; i++)
            //{
            //    if (n%i==0)
            //    {
            //        count++;
            //    }
            //}

            //if (count == 2)
            //{
            //    Console.WriteLine("The number is prime No");
            //}
            //else
            //{
            //    Console.WriteLine("The number is NOT a prime No");
            //}


            int result = CheckPrime(n, n / 2);
            if (result == 1)
            {
                Console.WriteLine("Prime No");

            }
            else
            {
                Console.WriteLine("Not a prime");
            }
            //call feature 1 here 
            Console.ReadLine();
        }

        /// <summary>
        /// this is the new branch commit
        /// </summary>
        /// <param name="n"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private static int CheckPrime(int n, int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                if (n % i == 0)
                {
                    return 0;
                }
                else
                {
                    return CheckPrime(n, i - 1);
                }
            }
        }

    }
}
