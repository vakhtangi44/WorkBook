using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBook.Logical
{
    internal class Fibonacci
    {
        public static void Start()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, number;
            Console.Write("Enter the number upto which print the Fibonacci series : ");
            number = int.Parse(Console.ReadLine());
            //First print first and second number
            Console.Write(firstNumber + " " + SecondNumber + " ");
            nextNumber = firstNumber + SecondNumber;
            //Starts the loop from 2 because 0 and 1 are already printed
            for (int i = 2; nextNumber < number; i++)
            {
                Console.Write(nextNumber + " ");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
                nextNumber = firstNumber + SecondNumber;
            }

        }
    }
}
