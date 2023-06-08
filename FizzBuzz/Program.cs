using System.Runtime.CompilerServices;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public string FizzBuzz(int num1)
        {
            if (num1 % 3 == 0 && num1 % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (num1 % 3 == 0)
            {
                return "fizz";
            }
            else if (num1 % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                return num1.ToString();
            }
        }

        public string FizzBuzz1(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return $"{number} : FizzBuzz";

            }
            else if (number % 3 == 0)
            {
                return $"{number} : Fizz";
            }
            else if (number % 5 == 0)
            {
                return $"{number} : Buzz";
            }
            else 
            {
                return $" {number}This number is not divisible by 3 or 5";
            }
        
        
        
        }




    }
}


/* what a method needs
 * access moodifier = public
 * return type = string
 *method name = fizzbuzz
 *parameters = int is for whole number and num1 for name 
 *scope = if statment 

Write a public method that accepts a number

when the number is divisible by 3 return the word fizz

when the number is divisible by 5 return the word buzz

when the number is divisible by both, return the word fizzbuzz

 
 */