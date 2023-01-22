using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbersList.Sort();
            int before = numbersList[0];
            int count = 0;
            foreach (int number in numbersList)
            {
                if (number == before)
                {
                    count++;
                }
                if (number != before)
                {
                    Console.WriteLine($"{before} -> {count}");
                    count = 1;
                }
                before = number;
            }
            Console.WriteLine($"{numbersList[numbersList.Count - 1]} - > {count}");
        }
    }
}
