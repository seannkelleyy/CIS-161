// Sean Kelley
// CIS-161 
//21 March 2022

class array
{
    static void Main()
    {
        // Initiates the array and sum variable 
        int[] numbers = new int[8];
        AddValues(numbers);
        decimal sum, average;
        ArrayFormat(out average, out sum, numbers);


    }
    static int[] AddValues(params int[] numbers)
    {
        for (int i = 0; i <= 8; i++)
        {
            Console.Write("Enter an integer value or the letter q to quit: ");
            string newValue = Console.ReadLine();
            if (newValue == "q")
            {
                break;
            }
            else
            {
                int intValue = Convert.ToInt32(newValue);
                numbers[i] = intValue;
            }
        }

        return numbers;
    }
    
    static void ArrayFormat(out decimal average, out decimal sum, params int[] numbers )
    {
        average = Convert.ToDecimal(numbers.Average());
        sum = Convert.ToDecimal(numbers.Sum());
        Console.WriteLine("The Array Values Are:");
        foreach (int value in numbers)
        {
            if (value != 0)
            {
                Console.Write($"{ value } ");
            }
            else if (value == 0)
            {
                continue;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"        Numbers Entered: { numbers.Length }");
        Console.WriteLine($"                    Sum: { sum }");
        Console.WriteLine($"                Average: { average}");    
    }
}