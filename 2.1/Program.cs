using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> answerList = list.ToList();
            foreach(var number in list)
            {
                if (number % 2 != 0)
                {
                    answerList.Remove(number);
                }
            }
            Console.WriteLine(string.Join(" ", answerList));
        }
    }
}
