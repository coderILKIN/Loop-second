using System;

namespace LOOPS_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

          while (number > 0)
            {
                sum = sum + number % 10;
                number /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}
