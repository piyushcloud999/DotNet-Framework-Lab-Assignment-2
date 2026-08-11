using System;

namespace Lab1_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStudent t = new TestStudent();
            t.TestAccess();

            Console.ReadKey();
        }
    }
}