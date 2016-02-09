using System;
using System.Collections.Generic;

namespace D7
{
    class Program
    {
        static int SafeDivision(int x, int y)
        {
            if (y == 0) throw new System.DivideByZeroException();
            return x / y;
        }

        static void Main(string[] args)
        {
            Case5();

            Console.ReadLine();
        }

        static void Case1()
        {
            int number1 = 100;
            int number2 = 0;

            try
            {

                int result = SafeDivision(number1, number2);
                Console.WriteLine("Result is {0}", result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Invalid user!, cannot divide by zero");
            }

        }

        static void Case2()
        {
            Console.Write("Give a number : ");
            string line = Console.ReadLine();

            try
            {
                int number = int.Parse(line);
                Console.WriteLine("you gave number: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Do you know what a number is?");
            }
        }

        static void Case3()
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Number is " + numbers[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("wrong index!");
            }
            finally
            {
                Console.WriteLine("Sipuli");
            }
        }

        static void Case4()
        {
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter("test.txt");
                outputFile.WriteLine("Here is a sample text to file.");
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
        }

        static void Case5()
        {
            try
            {
                Car car = new Car("Audi", "");
                Console.WriteLine("Car brand is {0} and model is {1}", car.Brand, car.Model);
            }
            catch (CarException apina)
            {
                Console.WriteLine(apina.Message); // output: Car model can't be empty!
                                               //Console.WriteLine(ex.ToString());
            }
        }
    }    
}
