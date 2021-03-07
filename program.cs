using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'The Quiz'\nPress enter to begin: ");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);
        }
    }
}