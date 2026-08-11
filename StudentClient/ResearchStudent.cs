using System;
using StudentLibrary;

namespace StudentClient
{
    class ResearchStudent : Student
    {
        public void ShowResearchAccess()
        {
            Console.WriteLine("Through Inheritance:");

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("College: " + College);

            // CGPA is internal, so it is not accessible here
            // Console.WriteLine("CGPA: " + CGPA);

            // Age is private, so it is not accessible
            // Console.WriteLine("Age: " + Age);

            // Address is private protected, so it is not accessible
            // Console.WriteLine("Address: " + Address);


            Student s = new Student();

            Console.WriteLine();
            Console.WriteLine("Through Student Object:");

            Console.WriteLine("Name: " + s.Name);

            // Console.WriteLine("Department: " + s.Department);
            // Console.WriteLine("College: " + s.College);
            // Console.WriteLine("CGPA: " + s.CGPA);
            // Console.WriteLine("Age: " + s.Age);
            // Console.WriteLine("Address: " + s.Address);
        }
    }
}