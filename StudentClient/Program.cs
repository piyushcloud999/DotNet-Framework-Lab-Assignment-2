using System;

namespace StudentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchStudent r = new ResearchStudent();
            r.ShowResearchAccess();

            Console.ReadKey();
        }
    }
}