using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool y = false;
            int x = 4;
            if(x == (int)x)
            {
                y = true;
            }
            Console.WriteLine(y);
        }
    
        public static bool isLeapYear(int year){
            bool isLeapYear = false;
            if(year % 4 == 0) 
            {   
                isLeapYear = true;
                if(year % 100 == 0)
                {
                    isLeapYear = false;
                }
            }
            if(year % 400 == 0)
            {
                isLeapYear = true;
            }
            return isLeapYear;
        }
    }
}
