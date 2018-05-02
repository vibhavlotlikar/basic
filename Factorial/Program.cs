namespace Factorial
{
    using System;

    public class Program
    {
        /// <summary>
        /// Admin controller
        /// </summary>
        static public void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The factorial of {0} is {1} ", n, Factorial_recursion(n));

            Console.ReadLine();
        }

        /// <summary>
        /// Factorial using recursion
        /// </summary>
        /// 
        public static double Factorial_recursion(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial_recursion(number - 1);
            }
        }
    }
}
