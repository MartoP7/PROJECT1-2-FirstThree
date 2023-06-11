using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var n in nums)
            {
                if (n > 0)
                {
                    Console.WriteLine($"{n} ---> {n * -1}");
                }
                else
                {
                    Console.Clear();
                    return;
                }
            }
        }
    }
}
