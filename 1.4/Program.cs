using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            string1 = string1.Replace(" ", "");
            string2 = string2.Replace(" ", "");
            byte[] ascii1 = Encoding.ASCII.GetBytes(string1);
            byte[] ascii2 = Encoding.ASCII.GetBytes(string2);
            int intVal1 = 0;
            int intVal2 = 0;
            bool ascii1Bigger = false;
            bool ascii2Bigger = false;
            if (string1 == string2) { }
            else
            {
                if (ascii1.Length > ascii2.Length)
                {
                    ascii2Bigger = true;
                }
                else if (ascii1.Length < ascii2.Length)
                {
                    ascii1Bigger = true;
                }
                else
                {
                    while (ascii1Bigger != true && ascii2Bigger != true)
                    {
                        for (int s1 = 0; s1 < ascii1.Length; s1++)
                        {
                            intVal1 = Convert.ToInt32(ascii1[s1]);
                            intVal2 = Convert.ToInt32(ascii2[s1]);
                            if (intVal1 < intVal2)
                            {
                                ascii1Bigger = true;
                            }
                            if (intVal1 > intVal2)
                            {
                                ascii2Bigger = true;
                            }
                        }
                    }
                }
            }
            if (ascii1Bigger = true && ascii2Bigger != true) 
            {
                Console.WriteLine(string1);
                Console.WriteLine(string2);
            }
            else if (ascii2Bigger = true && ascii1Bigger != true) 
            {
                Console.WriteLine(string2);
                Console.WriteLine(string1);
            }
            else
            {
                Console.WriteLine(string1);
                Console.WriteLine(string2);
            }
        }
    }
}
