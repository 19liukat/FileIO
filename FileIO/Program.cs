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
            
            //numbers = final array w/ int
    
            Console.WriteLine("Every multiple of three");
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

			for (int i = 0; i < numbers.Length; i++) {  //looping through array
				sum = sum + numbers[i];              //each element added to running sum
            }
            Console.WriteLine("Sum of list: " + sum); //displays sum
            // display the whole list
            Console.WriteLine("Whole List");
            for (int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }
            //displaying every even number
            Console.WriteLine("Every even number");
            for(int i = 0; i<numbers.Length; i++){
                if(numbers[i]%2==0){
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Every fifth number");
            for (int x=0; x<numbers.Length; x+=5){
                Console.WriteLine(numbers[x]);
                }
                //odd numbers
            Console.WriteLine("Every odd number");
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            
        
            Console.ReadKey();
    }
    }
}
            