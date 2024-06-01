using System;
using static System.Console;
class InchesToCentimeters
{
    static void Main()
    {
        const double cpi = 2.54;
        Write("Enter the measurement in inches: ");
        double inches = Convert.ToDouble(ReadLine());
        double centimeters = inches * cpi;
        WriteLine($"{inches} inches is {centimeters} centimeters.");
    }
}

