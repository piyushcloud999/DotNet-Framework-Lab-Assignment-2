using System;

namespace Lab1_AccessModifiers
{
    class GraduateStudent : Student
    {
        public void ShowData()
        {
            Console.WriteLine("Through Inheritance:");

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address: " + Address);

            Student s = new Student();

            Console.WriteLine();
            Console.WriteLine("Through Student Object:");

            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("CGPA: " + s.CGPA);
            Console.WriteLine("College: " + s.College);
        }
    }
}