using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Out of 100, what do you think you'll get at the end of ISM 4300? (Please do not input a % with the score).");

            int score;
            while (!int.TryParse(Console.ReadLine(), out score))
            {
                Console.WriteLine("Please enter a number.");
            }


            if (score >= 98 && score <= 100)
            {
                Console.WriteLine("You will receive an A+");
            }

            if (score >= 92 && score <= 97)
            {
                Console.WriteLine("You will receive an A");
            }

            if (score >= 90 && score <= 91)
            {
                Console.WriteLine("You will receive an -A");
            }

            if (score >= 88 && score <= 89)
            {
                Console.WriteLine("You will receive an B+");
            }

            if (score >= 82 && score <= 87)
            {
                Console.WriteLine("You will receive an B");
            }

            if (score >= 80 && score <= 81)
            {
                Console.WriteLine("You will receive an B-");
            }

            if (score >= 78 && score <= 79)
            {
                Console.WriteLine("You will receive an C+");
            }

            if (score >= 72 && score <= 77)
            {
                Console.WriteLine("You will receive an C");
            }

            if (score >= 70 && score <= 71)
            {
                Console.WriteLine("You will receive an C-");
            }

            if (score >= 68 && score <= 69)
            {
                Console.WriteLine("You will receive an D+");
            }

            if (score >= 62 && score <= 67)
            {
                Console.WriteLine("You will receive an D");
            }

            if (score >= 60 && score <= 61)
            {
                Console.WriteLine("You will receive an D-");
            }

            if (score >= 0 && score <= 59)
            {
                Console.WriteLine("You will receive an F");
            }
        }
    }
}
