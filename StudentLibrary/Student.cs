using System;

namespace StudentLibrary
{
    public class Student
    {
        public string Name = "Piyush";
        private int Age = 22;
        protected string Department = "Computer Applications";
        internal double CGPA = 7.4;
        protected internal string College = "GLA University";
        private protected string Address = "Agra";

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address: " + Address);
        }
    }
}