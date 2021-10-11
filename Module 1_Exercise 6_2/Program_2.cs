using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_6_2
{
    class Program_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку. Мы определим, вдруг это палиндром.");
            string userString = Console.ReadLine().ToLower();
            string[] userStringArray = userString.Split();

            // Сшиваем обратно прямую строку
            string straightString = String.Join("", userStringArray);
            

            string[] backStringArray = new string[1];
            // Заполняем обратную строку символами прямой в обратном порядке
            for (int i = straightString.Length - 1; i >= 0; i--)
            {
                backStringArray[0] = backStringArray[0] + straightString[i];
            }
            string backString = String.Join("", backStringArray);
            

            Console.WriteLine(straightString);
            Console.WriteLine(backString);
            Console.WriteLine();

            int flag = String.Compare(straightString, backString);
            if (flag == 0)
            {
                Console.WriteLine("Эта строка палиндром!");
            }
            else
            {
                Console.WriteLine("Увы, эта строка не палиндром...");
            }
            Console.ReadKey();

        }
    }
}
