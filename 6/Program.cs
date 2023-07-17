using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//ex 6

class Program
{
    static void Main(string[] args)
    {
        string[] DaysofWeek = { "Monday", "Tuesday", "Wednesday", "Thurusday", "Friday", "Saturday", "Sunday" };

        var days = from Week in DaysofWeek

                   select Week;

        foreach (var Week in days)

        {
            Console.WriteLine(Week);
        }


    }
}