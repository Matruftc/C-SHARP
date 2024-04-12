using System;

class leap_year{
    public static void Main(string[] args)
    {
        int year = 2024;
        

        if (year % 4 == 0 && year % 100 !=0 )
        {
            Console.WriteLine("hooray this is a leap year");
        }
        else{
            Console.WriteLine("this is not a leap year");
        }

    }
}