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
            
            for (int x=0; x<numbers.Length; x+=5){
                Console.WriteLine(numbers[x]);
                }
                Console.ReadKey();
            }
        
        
			}
		}
	



