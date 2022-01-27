﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Basicprograms
    {
        public void FlipCoin()
        {
            Console.WriteLine("Enter the number of times to Flip Coin");
            double num = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            double headCount = 0, tailCount = 0;
            for (int i = 0; i < num; i++)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
            }
            headCount *= (100 / num);
            tailCount *= (100 / num);
            Console.WriteLine("The Percentage of Heads vs Tails is {0}% and {1}%", headCount, tailCount);
            Console.ReadKey();
        }
        public void LeapYear()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
        }

        internal void Harmonic()
        {
            throw new NotImplementedException();
        }

        public void PowerOfTwo()
        {
            Console.WriteLine("Enter the power value");
            int exponent = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= exponent; i++)
            {
                Console.WriteLine("2^{0} " + " " + "= {1}", i, Math.Pow(2, i));
            }
        }
        public void Prime()
        {
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is a Prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime number");
            }
        }
        public void harmonic()
        {
            Console.WriteLine("Enter the last harmonic number");
            double num = Convert.ToDouble(Console.ReadLine());
            double harmonicSum = 0;
            for (double i = 1; i <= num; i++)
            {
                Console.WriteLine("1/" + i + "=" + (1 / i));
                harmonicSum += (1 / i);
            }
            Console.WriteLine("The Sum of harmonic number is :" + harmonicSum);
        }
        public void SwappingNumber()
        {
            Console.WriteLine("Enter the First number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("After Swapping these Two Numbers : First number is =" + firstNumber + " and Second number is =" + secondNumber);
        }
        public void Division()
        {
            Console.WriteLine("Enter the Dividend");
            double dividend = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            double divisor = Convert.ToDouble(Console.ReadLine());
            double quotient = dividend / divisor;
            double remainder = dividend % divisor;
            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
    }
}





