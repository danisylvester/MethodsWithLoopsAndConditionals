using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the range from -1000 to 1000
            Console.WriteLine("Here are the numbers between -1000 and 1000");
            PrintRangeThousand();
            Console.Clear();

            // Printing numbers 3 through 999 by 3 each time
            Console.WriteLine("Here is every 3rd number between 3 and 999.");
            PrintbyThree();
            Console.Clear();

            // Checking to see if two numbers provided by the user are equal.
            Console.WriteLine("Hi there! I'll tell you if two numbers are equivalent! \n" + "Enter your first number.");
            int userNum1CheckEqual = int.Parse(Console.ReadLine());
            Console.WriteLine("....................................................................");
            Console.WriteLine("Enter your second number.");
            int userNum2CheckEqual = int.Parse(Console.ReadLine());
            CheckEqual(userNum1CheckEqual, userNum2CheckEqual);
            Console.WriteLine("....................................................................");

            // Checking to see if a number provided by the user is even or odd
            Console.WriteLine("Enter a number and I'll tell you if it's even or odd!");
            int userNumCheckEvenOdd = int.Parse(Console.ReadLine());
            CheckOddEven(userNumCheckEvenOdd);
            Console.WriteLine("....................................................................");

            // Checking to see if the user's number entered is negative, positive, or zero.
            Console.WriteLine("Enter a number and I'll tell you if it's negative or positive.");
            int userNumCheckSign = int.Parse(Console.ReadLine());
            CheckSign(userNumCheckSign);
            Console.WriteLine("....................................................................");

            // Checking to see if user can vote.
            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());
            CheckCanVote(userAge);
            Console.WriteLine("....................................................................");

            // Checking to see if number is within -10 to 10 range
            Console.WriteLine("Enter a number. I'll let you know if it's within the -10 to 10 range!");
            int userNumRangeCheck = int.Parse(Console.ReadLine());
            CheckWithinRange10(userNumRangeCheck);
            Console.WriteLine("....................................................................");

            // Displaying the multiplication table from 1 to 12 of the number the user entered
            Console.WriteLine("I'll tell you the multiplication table from 1 to 12 of a number. \n" + "Enter a number!");
            int userNumMultiply = int.Parse(Console.ReadLine());
            Console.WriteLine("....................................................................");
            Multiply1To12(userNumMultiply);
            Console.WriteLine("....................................................................");

            // User defines an index and program returns an array of random numbers with that many indexes
            Console.WriteLine("I can give you a list of random numbers. \n" + "How many numbers would you like to see?");
            int userIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("....................................................................");
            RandomList(userIndex);
            Console.WriteLine("....................................................................");

            // Asks user for 5 numbers, stores values in an array, and adds elements of the array
            Console.WriteLine("I can tell you the sum of five integers!");

            List<int> listUserNum = new List<int>();

            Console.WriteLine("Enter the first number!");
            int num1_List = int.Parse(Console.ReadLine());
            listUserNum.Add(num1_List);
            Console.WriteLine("Enter the second number!");
            int num2_List = int.Parse(Console.ReadLine());
            listUserNum.Add(num2_List);
            Console.WriteLine("Enter the third number!");
            int num3_List = int.Parse(Console.ReadLine());
            listUserNum.Add(num3_List);
            Console.WriteLine("Enter the fourth number!");
            int num4_List = int.Parse(Console.ReadLine());
            listUserNum.Add(num4_List);
            Console.WriteLine("Enter the last number!");
            int num5_List = int.Parse(Console.ReadLine());
            listUserNum.Add(num5_List);

            SumList(listUserNum);
            Console.WriteLine("....................................................................");

            // Displaying the cube of every number up to a give integer (provided by user)
            Console.WriteLine("I can give you the cube of every integer up to a given integer.");
            Console.WriteLine("Enter an integer!");
            int userIntForCube = int.Parse(Console.ReadLine());
            CubeAll(userIntForCube);
        }

        public static void PrintRangeThousand()
        {
            for(int i = 1000; i >= -1000; i--)
            {
               Console.WriteLine($"{i}");
            }
        } 

        public static void PrintbyThree()
        {
            for(int i = 3; i <=999; i+=3)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void CheckEqual(int num1, int num2)
        {
            var equalResult = (num1 == num2) ? "These values are equal!" : "These values are not equal!";
            Console.WriteLine($"{equalResult}");
        }

        public static void CheckOddEven(int x)
        {
            if(x % 2 == 0)
            {
                Console.WriteLine($"{x} is even");
            }
            else
            {
                Console.WriteLine($"{x} is odd.");
            }
        }

        public static void CheckSign(int x)
        {
            if(x == 0)
            {
                Console.WriteLine($"You trickster, {x} is neutral.");
            }
            else if(x < 0)
            {
                Console.WriteLine($"{x} is negative.");
            }

            else
            {
                Console.WriteLine($"{x} is positive.");
            }
        }

        public static void CheckCanVote(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("Yay! You can vote.");
            }
            else
            {
                Console.WriteLine("Sorry, you're too young to vote!");
            }
        }

        public static void CheckWithinRange10(int x)
        {
            if(x >= -10 && x <= 10)
            {
                Console.WriteLine($"{x} is within the range of -10 through 10.");
            }
            else
            {
                Console.WriteLine($"{x} is not within range of -10 through 10.");
            }
        }

        public static void Multiply1To12(int x)
        {
            int result;
            for(int i = 1; i <= 12; i++)
            {
                result = x * i;
                Console.WriteLine($"{result}");
            }
        }

        public static void RandomList(int index)
        {
            var rand = new Random();

            for(int i = 0; i < index; i++)
            {
                var rndNum = rand.Next(1, 1000);
                Console.WriteLine($"{rndNum}");
            }
            
        }

        public static void SumList(List<int> list)
        {
            int sum = list.AsQueryable().Sum();
            Console.WriteLine($"The sum of this list is {sum}");

        }

        public static void CubeAll(int num)
        {
            for(var i = 1; i <= num; i++)
            {
                var cube = Math.Pow(i,3);
                Console.WriteLine($"Number is {i} and the cube of {i} is {cube}");
            }
        }
    }
}

