using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                if (GetDivisors(n).Sum() == n)
                {
                    Console.WriteLine("PERFECT number!");
                }
                else
                {
                    Console.WriteLine("Not a perfect number!");
                }
            }
            else
            {
                Console.WriteLine("The number should be positive!");
            }

        }
        static List<int> GetDivisors(int number)
        {   
            var divisors = new List<int>() {1};
            for (int i = 2; i <= number / 2; i++)
            {
                divisors.Add(i);
            }
            return divisors;
        }
    }
}
