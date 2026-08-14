using System;
using StudentLibrary;

namespace StudentClient
{
    class AccessStudent : Student
    {
        public void TestAccess()
        {
            Student student = new Student();

            // Public
            Console.WriteLine("Public Name: " + student.Name);

            // Protected
            Console.WriteLine("Protected Department: " + Department);

            // Protected Internal
            Console.WriteLine("Protected Internal College: " + College);

            Console.WriteLine("Private Age: Cannot Access");
            Console.WriteLine("Internal CGPA: Cannot Access");
            Console.WriteLine("Private Protected Address: Cannot Access");

        }
    }
}
