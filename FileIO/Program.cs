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
			int sum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = Int32.Parse(lines[i]);
            }
			for (int i = 0; i < numbers.Length; i++) {  //looping through array
				sum = sum + numbers[i];              //each element added to running sum
			
			}
			Console.WriteLine("Sum of list: " + sum); //displays sum
				Console.ReadKey();
			}
		}
	}



