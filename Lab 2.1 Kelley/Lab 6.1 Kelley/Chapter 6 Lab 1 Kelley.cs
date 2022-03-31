/* Sean Kelley
 * Chapter 6 lab 1
 * 27 February 2022
 */

namespace Phone;

    class Phone
{
    static void Main()
    {
        int[] areaCodeList = { 608, 414, 262, 815, 715, 920 };
        double[] costs = { .05, .10, .07, .24, .16, .14 };
        double totalCost = 0;
        int areaCodeIndex = 0;

        // This while loop keeps asking the user to input a correct area code.
        while (totalCost == 0)
        {
            Console.Write("Enter the area code of the number you would like to call: ");
            int areaCode = Convert.ToInt32(Console.ReadLine());
            
            // This if else statement checks to see if the list of area codes includes the area code that the user inputs.
            if (areaCodeList.Contains(areaCode))
            {
                Console.Write("Enter in the length of your phone call: ");
                int length = Convert.ToInt32(Console.ReadLine());

                // This for loop finds the index of the area code in the list.
                for (int i = 0; i < areaCodeList.Length; i++)
                {
                    if (areaCodeList[i] == areaCode)
                    {
                        areaCodeIndex = i;
                        break;
                    }
                }
                // Calculates the total cost of the phone call using the length of the phone call and the cost per minute for the area code. 
                totalCost = length * costs[areaCodeIndex];
                Console.WriteLine($"Your call to area code {areaCode} for {length} minutes will cost ${totalCost.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine("YOU MUST ENTER A VALID AREA CODE!");
            }
        }
    }
}