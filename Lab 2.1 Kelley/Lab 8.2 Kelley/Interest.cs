// Sean Kelley
// CIS-161
// 30 March 2021

class interest
{
    static void Main()
    {
        Console.Write("Enter the amount of money: ");
        double firstMoney = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the interest rate as a decimal (i.e. .04): ");
        double firstRate = Convert.ToDouble(Console.ReadLine());
        string firstInterest = Interest(firstMoney, firstRate);
        Console.WriteLine($"Money: ${ firstMoney.ToString("0.00")}");
        Console.WriteLine($"Rate : { firstRate }");
        Console.WriteLine($"Interest: ${ firstInterest }");
        Console.WriteLine();

        Console.Write("Enter the amount of money: ");
        double secondMoney = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the interest rate as an integer (i.e. 4): ");
        int secondRate = Convert.ToInt32(Console.ReadLine());
        string secondInterest = Interest(secondMoney, secondRate);
        Console.WriteLine($"Money: ${ secondMoney.ToString("0.00") }");
        Console.WriteLine($"Rate : { secondRate }");
        Console.WriteLine($"Interest: ${ secondInterest }");
    }

     static string Interest(double money, double rate)
     {
        string interest = (money * rate).ToString("0.00");    
        return interest;
     }

    static string Interest(double money, int rate)
    {
        string interest = (money * (rate * .01)).ToString("0.00");
        return interest;
    }
}