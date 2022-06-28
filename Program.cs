using System;

namespace QuestionNo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare an array of type integer and put some values in it
            int[] numbers = { 1, 2, 3, 4, 5, 6, };

            Console.WriteLine("Write the number which will be checked if it exists in our array named numbers");
            
            // read the integer and put it in variable named n
            int n = Convert.ToInt32(Console.ReadLine());
            // cycle through the array and find if n (the input asked) == any element in the array
           
            foreach (int i in numbers)
            {
                if (n == i)
                {
                    Console.WriteLine("The number you entered exists in the array called numbers");
                    break;
                }

            }
        }
    }
}
