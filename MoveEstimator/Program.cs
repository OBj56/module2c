using System;
using static System.Console;
using static System.Math;

public class MoveEstimator
{
    static void Main(string[] args)
    {
        const int baserate = 200;
        const int hourlyrate = 150;
        const decimal mileyrate = 2;

        Write("number of hours: ");
        decimal hours = decimal.Parse(ReadLine());
        Write("number of miles: ");
        decimal miles = decimal.Parse(ReadLine());

        decimal total = baserate + (hours * hourlyrate) + (miles * mileyrate);
        WriteLine(total.ToString("C")); 

    }

}