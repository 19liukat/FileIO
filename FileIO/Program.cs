using System;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name");
            string[] lines = System.IO.File.ReadAllLines(@Console.ReadLine());
        }
    }
}
