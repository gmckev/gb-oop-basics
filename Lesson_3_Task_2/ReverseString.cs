using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_2
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string s = ReversedString("gleb");
            Console.WriteLine(s);
            Console.ReadKey();
        }

        public static string ReversedString(string inputString)
        {
            string concat = "";
            for(int i = inputString.Length-1; i >= 0; i--)
            {
                concat = concat + inputString[i];
            }
            return concat;
        }
    }
}
