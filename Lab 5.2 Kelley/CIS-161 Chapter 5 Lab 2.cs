/* Sean Kelley
 * Chapter 5 Lab 2
 * Catherine Aldrich
 * CIS-161
 * 19 February 2022
 */

class loop
{
    static void Main()
    {
        int num = 1;
        Console.WriteLine("Odd values between 1 and 99 inclusive are:");
        while (num <= 99)
        {
            Console.Write(num + " ");
            num += 2;
        }
        Console.ReadLine();
    }

}