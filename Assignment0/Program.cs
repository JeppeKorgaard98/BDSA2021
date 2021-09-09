using System;
using System.IO;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Writes something and press [Enter]");
            }
            else
            {
                Console.WriteLine(args[0]);
            }
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number > 1582)
                    {
                        if (isLeapYear(number))
                        {
                            Console.WriteLine("yay");
                        }
                        else
                        {
                            Console.WriteLine("nay");
                        }
                    }
                    else
                    {
                        string[] output = { "Number must be higher than 1582" };
                        Program.Main(output);
                    }
                }
                catch (Exception)
                {
                    string[] output = { "Enter a number, not a word" };
                    Program.Main(output);
                }
            }

        }
        public static bool isLeapYear(int year)
        {
            bool isLeapYear = false;
            if (year % 4 == 0)
            {
                isLeapYear = true;
                if (year % 100 == 0)
                {
                    isLeapYear = false;
                }
            }
            if (year % 400 == 0)
            {
                isLeapYear = true;
            }
            return isLeapYear;
        }
    }
}
