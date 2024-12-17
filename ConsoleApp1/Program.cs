using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"европейские государства"};
            list.Add("классные");
            Out(list);
            Console.WriteLine();
            To(list);
            Console.WriteLine(list.Count);
            Console.WriteLine();
            list.Insert(2, "слово");
            Out(list);
            Console.WriteLine();
            list.Insert(0, "другое");
            Out(list);
            Console.WriteLine();
            list.RemoveAt(3);
            Out(list);
            Console.WriteLine();
            list.Reverse();
            Out(list);
            Console.ReadLine();
        }
        static void To(List<string> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.ToUpper());
            }
        }
            static void Out(List<string> list)
        {
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
