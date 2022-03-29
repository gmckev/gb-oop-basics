using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_3
{
    internal class Parser
    {
        static void Main(string[] args)
        {
            string[] names = File.ReadAllLines("names.txt");
            for(int i = 0; i < names.Length; i++)
            {
                SearchMail(ref names[i]);
                File.AppendAllLines("emails.txt", new string[] { names[i] });
            }

            Console.ReadKey();

        }

        public static void SearchMail(ref string s)
        {
            string[] arr = s.Split('&');
            s = arr[1];
        }
    }
}
