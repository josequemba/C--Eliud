using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
        List<int> numbers = new List<int>();

        int number = -1;
        int sum = 0;
        int objectNumber;
        float average = 0;
        int largest = 0;

        Console.WriteLine ("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write ("Enter number: ");
            number = int.Parse(Console.ReadLine());

            numbers.Add (number);
        }

            //The sum
            sum = numbers.Sum();

            Console.WriteLine ($"The sum is: {sum}");
   
            //The average 
            objectNumber = numbers.Count - 1;
            float su = sum;
            average = su / objectNumber;
           
            Console.WriteLine ($"The average is: {average}");

            // The largest number
            foreach (int numberLargest in numbers)
            {
                if (numberLargest > largest)
                {
                    largest = numberLargest;
                }
            }
            Console.WriteLine ($"The largest number is: {largest}");




    }
}