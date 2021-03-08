using System;

namespace Task1
{
    class Program   //Task 1 --- Sample 2
    {
        private static void ShowSequnce(int[] arr)  //Display the array
        {
            Console.WriteLine("Sequence:");
            foreach (int i in arr)  //interate array using foreach loop
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        private static void DisplayPrime(int[] numbersequence)  //Display All Prime Numbers in sequnce
        {
            Console.WriteLine("Prime Numbers:");
            foreach (int i in numbersequence)   //iterate all array using foreach loop
            {
                int num = 2;    //first Number to check if number divides
                bool isPrime = true;    //flag to check if number was prime or not
                while (num < i) // iterate numbers to check result of division on all numbers from 2 to the number itself
                {
                    if (i % num++ == 0) //if number divides
                    {
                        isPrime = false;    //it is not prime
                    }
                }
                if (isPrime)    //if number is prime display it
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        private static void DisplayMultiplesOf(int num, int[] sequnce)  //Displays multiples of num
        {
            Console.WriteLine("Multiples of {0}:", num);
            bool multipleFound = false; //to check if any multiples is found or not
            foreach (int i in sequnce)  
            {
                if (i % num == 0)   //if number divides display it
                {
                    multipleFound = true;
                    Console.Write(i + " ");
                }
            }
            if (!multipleFound) //if no multiple was found display message
            {
                Console.Write("No Multiples of {0} Found", num);
            }
            else
            {
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] Numbersequence = new int[20]; //create array to store sequnce
            Random sequnceGenerator = new Random(); //random number generator
            int i = 0;
            while (i < Numbersequence.Length)   //iterate array
            {
                Numbersequence[i++] = sequnceGenerator.Next(1, 100);    //store random numbers between 1 - 100 in all locations
            }
            //Calling functions to display Requirements
            ShowSequnce(Numbersequence);
            DisplayPrime(Numbersequence);
            DisplayMultiplesOf(3, Numbersequence);
            DisplayMultiplesOf(5, Numbersequence);
        }
    }
}
