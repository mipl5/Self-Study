using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Self_Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstFunction();
            SecondFunction();
            ThirdFunction();
            FourthFunction();
            FifthFunction();
        }
        public static void FirstFunction()
        {
            // Page: 146, Exercise: 8:
            int number = 1;
            int count = 0;
            while (number > 0)
            {
                if (number > 0)
                {
                    number = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            int realCount = count - 1;
            Console.WriteLine(realCount);
        }
        public static void SecondFunction()
        {
            // Page: 151, Exercise: 19:
            int firstNumber = 1, secondNumber = 1;
            int firstNumberSecondVersion;
            int numberInfirstNumberSecondVersion;
            int firstMultiple = 1;
            int secondNumberSecondVersion;
            int numberInsecondNumberSecondVersion;
            int secondMultiple = 1;
            int sumOfMultiples = 0;
            bool condition = true;
            while (firstNumber != 0 && secondNumber != 0)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                if (firstNumber > 0 && secondNumber > 0) {
                    firstMultiple = 1;
                    secondMultiple = 1;
                    firstNumberSecondVersion = firstNumber;
                    while (firstNumberSecondVersion > 0)
                    {
                        numberInfirstNumberSecondVersion = firstNumberSecondVersion % 10;
                        firstMultiple *= numberInfirstNumberSecondVersion;
                        firstNumberSecondVersion /= 10;
                    }
                    secondNumberSecondVersion = secondNumber;
                    while (secondNumberSecondVersion > 0)
                    {
                        numberInsecondNumberSecondVersion = secondNumberSecondVersion % 10;
                        secondMultiple *= numberInsecondNumberSecondVersion;
                        secondNumberSecondVersion /= 10;
                    }
                    Console.WriteLine("[First (1)] multiple: {0}", firstMultiple);
                    Console.WriteLine("[Second (2)] multiple: {0}", secondMultiple);
                    sumOfMultiples = firstMultiple + secondMultiple;
                    Console.WriteLine(sumOfMultiples);
                    if (sumOfMultiples < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                    else if (sumOfMultiples > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                if (firstNumber < 0 && secondNumber < 0)
                {
                    firstMultiple = 1;
                    secondMultiple = 1;
                    firstNumberSecondVersion = 0 - (firstNumber);
                    while (firstNumberSecondVersion > 0)
                    {
                        numberInfirstNumberSecondVersion = firstNumberSecondVersion % 10;
                        firstMultiple *= numberInfirstNumberSecondVersion;
                        firstNumberSecondVersion /= 10;
                    }
                    secondNumberSecondVersion = 0 - (secondNumber);
                    while (secondNumberSecondVersion > 0)
                    {
                        numberInsecondNumberSecondVersion = secondNumberSecondVersion % 10;
                        secondMultiple *= numberInsecondNumberSecondVersion;
                        secondNumberSecondVersion /= 10;
                    }
                    Console.WriteLine("[First (1)] multiple: {0}", -firstMultiple);
                    Console.WriteLine("[Second (2)] multiple: {0}", -secondMultiple);
                    sumOfMultiples = (-firstMultiple) + (-secondMultiple);
                    Console.WriteLine(sumOfMultiples);
                    if (sumOfMultiples < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                    else if (sumOfMultiples > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                if (firstNumber < 0 && secondNumber > 0)
                {
                    firstMultiple = 1;
                    secondMultiple = 1;
                    firstNumberSecondVersion = 0 - (firstNumber);
                    while (firstNumberSecondVersion > 0)
                    {
                        numberInfirstNumberSecondVersion = firstNumberSecondVersion % 10;
                        firstMultiple *= numberInfirstNumberSecondVersion;
                        firstNumberSecondVersion /= 10;
                    }
                    secondNumberSecondVersion = (secondNumber);
                    while (secondNumberSecondVersion > 0)
                    {
                        numberInsecondNumberSecondVersion = secondNumberSecondVersion % 10;
                        secondMultiple *= numberInsecondNumberSecondVersion;
                        secondNumberSecondVersion /= 10;
                    }
                    Console.WriteLine("[First (1)] multiple: {0}", -firstMultiple);
                    Console.WriteLine("[Second (2)] multiple: {0}", secondMultiple);
                    sumOfMultiples = (-firstMultiple) + (secondMultiple);
                    Console.WriteLine(sumOfMultiples);
                    if (sumOfMultiples < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                    else if (sumOfMultiples > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                if (firstNumber > 0 && secondNumber < 0)
                {
                    firstMultiple = 1;
                    secondMultiple = 1;
                    firstNumberSecondVersion = (firstNumber);
                    while (firstNumberSecondVersion > 0)
                    {
                        numberInfirstNumberSecondVersion = firstNumberSecondVersion % 10;
                        firstMultiple *= numberInfirstNumberSecondVersion;
                        firstNumberSecondVersion /= 10;
                    }
                    secondNumberSecondVersion = 0 - (secondNumber);
                    while (secondNumberSecondVersion > 0)
                    {
                        numberInsecondNumberSecondVersion = secondNumberSecondVersion % 10;
                        secondMultiple *= numberInsecondNumberSecondVersion;
                        secondNumberSecondVersion /= 10;
                    }
                    Console.WriteLine("[First (1)] multiple: {0}", firstMultiple);
                    Console.WriteLine("[Second (2)] multiple: {0}", -secondMultiple);
                    sumOfMultiples = (firstMultiple) + (-secondMultiple);
                    Console.WriteLine(sumOfMultiples);
                    if (sumOfMultiples < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                    else if (sumOfMultiples > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else
                {
                    condition = false;
                }
            }
        }
        public static void ThirdFunction()
        {
            // Page: 151, Exercise: 20:
            int perUnit = 30;
            int count = 0;
            int length = 1;
            int height = 1;
            int sumArea = 0;
            while ((length > 0 || height > 0) && sumArea <= 200)
            {
                length = int.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                sumArea += length * height;
                count++;
            }
            int sum = count * perUnit;
            Console.WriteLine(sum);
        }
        public static void FourthFunction()
        {
            // Page: 151, Exercise: 21:
            double number = double.Parse(Console.ReadLine());
            int n = (int)number;
            int count = 0;
            if (n == 0)
            {
                count = 1;
                Console.WriteLine(count);
            }
            else if (n > 0)
            {
                while (n > 0)
                {
                    n /= 10;
                    count++;
                }
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("There is no output.");
            }
        }
        public static void FifthFunction()
        {
            // Page: 151, Exercise: 22:
            bool condition = true;
            int firstNumber = 10;
            int secondNumber = 10;
            int sum = 0;
            int maxSum = 0;
            int count = 0;
            int maxFirstNumber = 0;
            int maxSecondNumber = 0;
            while (condition == true && firstNumber > 9 && firstNumber < 100 && secondNumber > 9 && secondNumber < 100)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                if (firstNumber % 2 == 0 && secondNumber % 2 != 0)
                {
                    condition = false;
                }
                else if (firstNumber % 2 != 0 && secondNumber % 2 == 0)
                {
                    condition = false;
                }
                else
                {
                    sum = firstNumber + secondNumber;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxFirstNumber = firstNumber;
                        maxSecondNumber = secondNumber;
                        count++;
                    }
                }
            }
            Console.WriteLine(maxFirstNumber);
            Console.WriteLine(maxSecondNumber);
            Console.WriteLine(count);
        }
    }
}
