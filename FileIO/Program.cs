using System;
using System.IO;
namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the file name");
            string[] lines = System.IO.File.ReadAllLines(@Console.ReadLine());
            int[] numbers = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = int.Parse(lines[i]);
            }
            //numbers = final array w/ int
            Console.ReadKey();
			}
		}
	}


