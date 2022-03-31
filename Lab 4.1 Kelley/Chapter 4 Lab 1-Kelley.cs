/* Sean Kelley
 * Chapter 4 Lab 1
 * 12 February 2022
 */

using static System.Console;
class Pay
{
    static void Main()
    {
        decimal withholdingRate = .1M;
        Console.WriteLine("Enter your hours worked:");
        decimal hoursWorked = Convert.ToDecimal(ReadLine());
        Console.WriteLine("Enter your pay rate:");
        decimal payRate = Convert.ToDecimal(ReadLine());

        decimal grossPay = hoursWorked * payRate;

        if (grossPay > 300) 
        {
            withholdingRate = .12M;
        }

        decimal withholding = grossPay * withholdingRate;
        decimal netPay = grossPay - withholding;

        Console.WriteLine("The employee worked " + hoursWorked + " hours at a " +
            "pay rate of $" + payRate + " per hour.");
        Console.WriteLine("Gross pay: $" + grossPay.ToString("0.00"));
        Console.WriteLine("Withholding: $" + withholding.ToString("0.00"));
        Console.WriteLine("Net pay: $" + netPay.ToString("0.00"));


    }
}
