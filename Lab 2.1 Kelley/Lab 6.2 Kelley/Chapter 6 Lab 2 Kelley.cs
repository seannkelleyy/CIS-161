/* Sean Kelley
 * Chapter 6 Lab 2
 * 27 February 2022
 */

namespace numbers;

class numbers
{
    static void Main()
    {
        // Initiates the arrays and sum variable 
        decimal[] numbers = new decimal[10] ;
        decimal[] pricesBiggerThan5 = new decimal[10] ;
        decimal sum = 0;

        // Allows user to enter prices
        for (int i = 0; i < numbers.Length; i++ )
        {
            Console.Write($"Enter price {i + 1}: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            numbers[i] = price;
        }

        Console.WriteLine();

        // This for loop adds the prices together and stores the value into the sum variable
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"The sum of the prices is ${sum.ToString("0.00")}");

        // This for loop parses through the array and writes the values that are greater than $5.00
        Console.WriteLine("The values greater than $5.00 are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= 5)
            {
                Console.Write($"${numbers[i].ToString("0.00")} ");
            }
        }
        Console.WriteLine();

        // this variable calculates the average using the sum variable and the length of the array
        decimal average = sum / numbers.Length;
        Console.WriteLine($"The average of all values is ${average.ToString("0.00")} ");

        // this for loop parses through the numbers array and compares each value
        // to the average and writes the values that are below the average
        Console.WriteLine("The values less than the average are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < average)
            {
                Console.Write($"${numbers[i].ToString("0.00")} ");
            }
        }

        Console.ReadLine();
    }

    

}