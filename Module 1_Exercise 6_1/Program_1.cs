using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_6_1
{
    class Program_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку. Мы посчитаем какова длина самого длинного слова в этой строке.");
            string userString = Console.ReadLine();
            string[] userStringArray = userString.Split();
            int maxLen = 0;
            string maxString = "";
            foreach (string str in userStringArray)
            {
                int userStringLen = str.Length;
                if (userStringLen > maxLen)
                {
                    maxLen = userStringLen;
                    maxString = str;
                }
            }

            Console.WriteLine("Самое длиное слово: {0}. Его длина: {1}", maxString, maxLen);
            Console.ReadKey();
        }
    }
}
