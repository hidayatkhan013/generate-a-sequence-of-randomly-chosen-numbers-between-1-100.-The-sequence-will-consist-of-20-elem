using System;

namespace Task_1
{
    class Program   //Task 1 --- Sample 1
    {
        public static bool IsPrime(int num) //Function to check if number is prime
        {
            for (int i = 2; i < num; i++)   //starting from 2 to the number itself
            {
                if (num % i == 0)   //if number to check divides any number
                {
                    return false;   //It is not prime
                }
            }
            return true;    //if number doesnot divide any other number it is prime
        }
        public static int[] GenerateRandomNumbers(int lowerLimit, int upperLimit)   //Returns array of size 20 with random numbers 
        {
            int[] numbers = new int[20];    //array to store numbers
            Random random = new Random();   //Random Number generator
            for (int i = 0; i < 20; i++)    //iterating the array
            {
                numbers[i] = random.Next(lowerLimit, upperLimit);   //saving random numbers to array
            }
            return numbers;     //return the array
        }
        static void Main(string[] args)
        {
            int[] sequence = GenerateRandomNumbers(1, 100); //array to store sequnce
            //Displaying All Sequnce
            Console.WriteLine("Displaying Sequence:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} ", sequence[i]);
            }
            //Displaying All Prime Numbers
            Console.WriteLine("\nDisplaying Prime Numbers:");
            for (int i = 0; i < 20; i++)    //iterating the sequnce
            {
                if (IsPrime(sequence[i]))   //checking if number is prime
                {
                    Console.Write("{0} ", sequence[i]);
                }
            }
            bool is3 = false;   //flag to check if a multiple of 3 is found or not
            //Displaying Multiples of 3
            Console.WriteLine("\nDisplaying Multiples of 3:");
            for (int i = 0; i < 20; i++)
            {
                if (sequence[i] % 3 == 0)   //if Number divides 3 ... Display it
                {
                    is3 = true; //set flag true if number divides 5
                    Console.Write("{0} ", sequence[i]);
                }
            }
            if (is3 == false)   //If No Number divides 3 this message will be displayed
            {
                Console.WriteLine("There are no multiples of 3 in the sequence");
            }
            bool is5 = false;   //flag to check if a multiple of 5 is found or not
            Console.WriteLine("\nDisplaying Multiples of 5:");
            for (int i = 0; i < 20; i++)
            {
                if (sequence[i] % 5 == 0)    //if Number divides 5 ... Display it
                {
                    is5 = true; //set flag true if number divides 5
                    Console.Write("{0} ", sequence[i]);
                }
            }
            if (is5 == false)   //If No Number divides 5 this message will be displayed
            {
                Console.WriteLine("There are no multiples of 5 in the sequence");
            }
        }
    }
}
