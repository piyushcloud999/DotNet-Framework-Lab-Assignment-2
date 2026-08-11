using System;
using StudentLibrary;

namespace StudentClient
{
    class AccessStudent
    {
        public void TestAccess()
        {
            Student s = new Student();

            Console.WriteLine("Name: " + s.Name);

            // Console.WriteLine("Age: " + s.Age);
            // Console.WriteLine("Department: " + s.Department);
            // Console.WriteLine("CGPA: " + s.CGPA);
            // Console.WriteLine("College: " + s.College);
            // Console.WriteLine("Address: " + s.Address);
        }
    }
}