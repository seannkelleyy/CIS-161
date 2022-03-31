/*
 * lab 2.1
 * Sean Kelley
 * 30 January 2022
 */

using static System.Console;

class Cost
{
    static void Main()
    {
        double Length = 25.0;
        double Width = 42;
        double squareFeet = Length * Width;
        double squareYards = squareFeet / 9;
        float Cost = 22.32F;
        double totalCost = Cost * squareYards;
        string FormattedPrice = totalCost.ToString("N");


        Console.WriteLine("Your room of " + Length + " by " + Width +
            " contains " + squareFeet + " square feet or " + squareYards.ToString("0.00") +
            " square yards. ");
        Console.WriteLine("At a cost of $" + Cost + " this will cost you $" + FormattedPrice + ".");
    }

}