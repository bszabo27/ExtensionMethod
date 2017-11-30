using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    static class EnumerableExtensions
    {
        public static IEnumerable<T> EnsureSize<T>(this IEnumerable<T> enumerable, int size, T obj)
        {
            List<T> newEnumerable = new List<T>(enumerable);
            while (newEnumerable.Count < size)
            {
                newEnumerable.Add(obj);
            }

            return newEnumerable;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Top 6 list
            List<string> topList = new List<string>(new[] { "Peti", "Kati", "Joci" });

            var list = topList.EnsureSize(6, "---");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
