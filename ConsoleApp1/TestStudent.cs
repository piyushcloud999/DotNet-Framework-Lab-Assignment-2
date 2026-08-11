using System;

namespace Lab1_AccessModifiers
{
    class TestStudent
    {
        public void TestAccess()
        {
            Student s = new Student();

            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("CGPA: " + s.CGPA);
            Console.WriteLine("College: " + s.College);
        }
    }
}