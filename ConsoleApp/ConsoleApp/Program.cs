using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            HasContent2(lst);
            if (lst.Count == 0)
            {
                Console.Write("123");
            }
                
            Console.Write("Hello,World");
            Console.ReadKey();
        }
        private static bool HasContent2(List<string> strings)
        {
            return strings.Count() >= 1;  // Noncompliant
        }
    }
}
