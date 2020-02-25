// This is a program where every time you enter a number it adds that number to a list and 
// returns the sum, the largest number, the smallest number, the average, and the number of 
// even numbers.Stop the program when a 'X' is entered.

// Goal 1) Don't forget to test the input for the other non-digits and give a meaningful error message. 
// Goal 2) Allow only integers at first but see what changes when you allow real numbers.

using System;
using System.Collections.Generic;

namespace NumberList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();

            do
            {
                Console.Write("Please enter a number: ");
                string strNumber = Console.ReadLine();
                if (strNumber != "X")
                {
                    int intNum = Int32.Parse(strNumber);
                    Numbers.Add(intNum);
                    Statistics(Numbers);
                }
                else
                {
                    break;
                }
                
                
            } 
            while (true);
            
        }

        public static void Statistics(List<int> args)
        {
            int smallest = 2147483647;
            int largest = -2147483647;
            int total = 0;
            int average = 0;
            int numEven = 0;
            for (int i = 0; i < args.Count; i++)
            {
                smallest = (args[i] < smallest) ? args[i] : smallest;
                largest = (args[i] > largest) ? args[i] : largest;
                total = total + args[i];
                average = total / args.Count;
                numEven = (args[i] % 2 == 0) ? numEven + 1 : numEven;
            }

            Console.WriteLine("The smallest number is: " + smallest);
            Console.WriteLine("The largest number is: " + largest);
            Console.WriteLine("The total is: " + total);
            Console.WriteLine("The average is: " + average);
            Console.WriteLine("Total even numbers: " + numEven);
            Console.WriteLine();
        }
    }
}
