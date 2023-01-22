using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(",", "");
            List<int> numbersList = input.Split(' ').Select(int.Parse).ToList();
            List<int> helperList = numbersList.ToList();
            helperList.Sort();
            int before = helperList[0];
            int count = 0;
            foreach(var number in helperList)
            {
                if(number == before)
                {
                    count++;
                }
                if(number != before)
                {
                    if (count % 2 != 0)
                    {
                        for (int s1 = 0; s1 < count; s1++)
                        {
                            numbersList.Remove(before);
                        }
                    }
                    count = 1;
                }
                before = number;
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
