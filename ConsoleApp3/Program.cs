using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Задание 3. Создать список из целых чисел. Определить сумму значений элементов списка, кратных 5.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 3, 4, 8, 4, 6, 11, 7, 10, 15 };
            //var res = list.Where(x => x % 5 == 0).ToList();
            Console.WriteLine($"{Out(list)}");
            Console.ReadLine();

        }
        static int Out(List<int> list)
        {
            int s = 0;
            foreach (var element in list)
            {
                if (element % 5 == 0)
                {
                    s += element;
                }
            }
            return s;
        }
    }
}
