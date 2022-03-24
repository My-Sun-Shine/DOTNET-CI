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
            int await = 42;
            string i = "1";
            string j = "1";
            List<string> lst = new List<string>();
            if (i == j)
            {
                Console.Write("345");
            }
            if (HasContent2(lst))
            {
                Console.Write("123");
            }
                
            Console.Write("Hello,World");
            Console.ReadKey();
            Main_1();
            int target1 = -5;
            int num = 3;

            target1 -= num;  // Noncompliant; target = -3. Is that really what's meant?
            target1 += num; // Noncompliant; target = 3
           
        }
       

        private static bool HasContent2(List<string> strings)
        {
            return strings.Count() >= 1;  // Noncompliant
        }
        static void Main_1()
        {
            int await = 42;
            string i = "1";
            string j = "1";
            List<string> lst = new List<string>();
            if (i == j)
            {
                Console.Write("345");
            }
            if (HasContent2(lst))
            {
                Console.Write("123");
            }

            Console.Write("Hello,World");
            Console.ReadKey();
        }
       
    }


    class MyClass
    {
        public MyClass()
        {
            int x = 1;
            if (x == 0)
            {
                doSomething();
            }
            else if (x == 1)
            {
                doSomethingElse();
            }
        }
        private static bool HasContent2(List<string> strings)
        {
            return strings.Count() >= 1;  // Noncompliant
        }
        static void Main_1()
        {
            int await = 42;
            string i = "1";
            string j = "1";
            List<string> lst = new List<string>();
            if (i == j)
            {
                Console.Write("345");
            }
            if (HasContent2(lst))
            {
                Console.Write("123");
            }

            Console.Write("Hello,World");
            Console.ReadKey();
        }
        void doSomething()
        {

        }

        void doSomethingElse()
        {

        }
        public virtual void Method(int[] numbers)
        { }
    }


    class Base
    {
        public virtual void Method(int[] numbers)
        {}
        private static bool HasContent2(List<string> strings)
        {
            return strings.Count() >= 1;  // Noncompliant
        }
        static void Main_1()
        {
            int await = 42;
            string i = "1";
            string j = "1";
            List<string> lst = new List<string>();
            if (i == j)
            {
                Console.Write("345");
            }
            if (HasContent2(lst))
            {
                Console.Write("123");
            }

            Console.Write("Hello,World");
            Console.ReadKey();
        }
    }
    class Derived : Base
    {
        public override void Method(params int[] numbers) // Noncompliant, method can't be called with params syntax.
        {}
        private static bool HasContent2(List<string> strings)
        {
            return strings.Count() >= 1;  // Noncompliant
        }
        static void Main_1()
        {
            int await = 42;
            string i = "1";
            string j = "1";
            List<string> lst = new List<string>();
            if (i == j)
            {
                Console.Write("345");
            }
            if (HasContent2(lst))
            {
                Console.Write("123");
            }

            Console.Write("Hello,World");
            Console.ReadKey();
        }
    }

}
