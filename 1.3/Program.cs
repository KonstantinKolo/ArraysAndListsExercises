using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void MaxOccurrence(int[] numbers)
        {
            var groups = numbers.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            Console.WriteLine("The most common number is {0} and it appears {1} times", largest.Key, largest.Count());
        }

        public static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            MaxOccurrence(array);
        }               
    }
}
