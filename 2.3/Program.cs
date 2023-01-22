using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = int.MinValue;
            int min = int.MaxValue;
            int countMax = 0;
            int countMin = 0;
            string maxAnswer = "";
            string minAnswer = "";
            for (int s1 = 0; s1 < numbersList.Count; s1++)
            {
                if (numbersList[s1] < min)
                {
                    min = numbersList[s1];
                }
                if (numbersList[s1] > max)
                {
                    max = numbersList[s1];
                }
            }
            foreach(var number in numbersList)
            {
                if(number == max)
                {
                    countMax++;
                }
                if (number == min)
                {
                    countMin++;
                }
            }
            for (int s2 = 0; s2 < countMax; s2++)
            {
                maxAnswer = maxAnswer + max + " ";
            }
            for (int s3 = 0; s3 < countMin; s3++)
            {
                minAnswer = minAnswer + min + " ";
            }
            if (maxAnswer != minAnswer)
            {
                Console.WriteLine($"{minAnswer}{maxAnswer}");
            }
            else
            {
                Console.WriteLine($"{minAnswer}");
            }
        }
    }
}
