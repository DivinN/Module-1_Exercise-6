using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_6_3
{
    class Program_3
    {
        static void Main(string[] args)
        {
            // Пример {строки} с ковычками {а тут {вложенные} ковычки}
            
            Console.WriteLine("Введите строку. Мы удалим все в фигурных скобках.");
            string userString = Console.ReadLine();

            // Удаляем подстроки в ковычках до тех пор, пока ковычек не останется
            while (userString.Contains("{"))
            {
                int indexFirst = userString.LastIndexOf("{");
                int indexLast = userString.IndexOf("}", indexFirst);

                userString = userString.Remove(indexFirst, indexLast - indexFirst + 1);
            }

            Console.WriteLine(userString);
            Console.ReadKey();
        }
    }
}
