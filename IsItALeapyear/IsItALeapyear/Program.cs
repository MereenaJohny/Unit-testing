using System;

namespace IsItALeapyear
{
   public class Program
    {
        public bool IsItALeapYear(int y)
        {
            if ((y % 4 == 0) && (y % 100 != 0 || y % 400 == 0))
            {
                Console.WriteLine(y + ":leap year");
                return true;
            }
            else
            {
                Console.WriteLine(y + ": not a leap year");
                return false;
            }
        }
        static void Main(string[] args)
      
        {
            Console.WriteLine("Leap year?!");
        }
    }
}

