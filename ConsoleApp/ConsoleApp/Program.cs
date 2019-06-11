using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            int await = 42; // Noncompliant
            List<string> lst = new List<string>();
            
            if (HasContent2(lst);)
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
