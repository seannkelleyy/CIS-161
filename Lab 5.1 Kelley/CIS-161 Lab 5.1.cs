/* Sean Kelley 
 * Lab 5.1
 * Catherine Aldrich
 * CIS-161
 * 19 February 2022
 */

using System;
    
class number
{
    static void Main()
    {
        int num;
        while (true)
        {
            Console.WriteLine("Enter an integer (999 to exit)");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 999)
            {
                continue;
            }
            else if (num == 999)
            {
                System.Environment.Exit(1);
            }
        }
    }

}
