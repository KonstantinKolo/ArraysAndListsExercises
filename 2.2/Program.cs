using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> answerList = numberList.ToList();
            foreach (var number in numberList)
            {
                if (number < 0)
                {
                    answerList.Remove(number);
                }
            }
            answerList.Reverse();
            if (answerList.Count > 0)
            {
                Console.WriteLine(string.Join(" ",answerList));
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}
