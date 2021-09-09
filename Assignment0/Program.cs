using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Writes something and press [Enter]");
            int number = Convert.ToInt32(Console.ReadLine());
            if (isLeapYear(number))
            {
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
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
