using System;
using System.IO;
using System.Reflection;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "//Text.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            int[] numbers = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = int.Parse(lines[i]);
            }
            // display the whole list
            for (int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
			}
		}
	}



