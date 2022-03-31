/* Sean Kelley
 * Chapter 5 Lab 3
 * Catherine Aldrich 
 * CIS-161
 * 20 February 2022
 */

class toothpick
{
    static void Main()
    {
        int toothPicks = 23;
        int userToothpick = 0;
        int computerToothpicks = 0;

        while (toothPicks > 0)
        {
            Console.WriteLine("How many toothpicks " +
                "would like you to take (1, 2 or 3?");
            userToothpick = Convert.ToInt32(Console.ReadLine());

            while (true)
                if (userToothpick > 3 | userToothpick < 1)
                {

                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("How many toothpicks " +
                        "would like you to take (1, 2 or 3?");
                    userToothpick = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    break;
                }

            while (true)
            {
                if (userToothpick > 3 && userToothpick < 1)
                {
                    Console.WriteLine("Invalid input.");
                }
                else
                {
                    break;
                }

            }

            toothPicks = toothPicks - userToothpick; 

            if (toothPicks  > 1)
            {
                Console.WriteLine($"You took {userToothpick} toothpicks. " +
                $"There are {toothPicks} toothpicks left.");
            }
            else if (toothPicks <1)
            {
                Console.WriteLine($"You took {userToothpick} toothpicks. " +
                $"There are 0 toothpicks left.");
                Console.WriteLine("You lose!");
            }

            if (toothPicks > 4)
            {
                computerToothpicks = 4 - userToothpick;

                toothPicks = toothPicks - computerToothpicks;

                Console.WriteLine($"The computer took {computerToothpicks}"
                    + $" toothpicks. There are {toothPicks}"
                    + " toothpicks left.");
            }
            else if ((toothPicks <= 4) && (toothPicks > 1))
            {
                computerToothpicks = toothPicks - 1;

                toothPicks = toothPicks - computerToothpicks;

                Console.WriteLine($"The computer took {computerToothpicks}"
                    + $" toothpicks. There are {toothPicks}"
                    + " toothpicks left.");
            }
            else if (toothPicks == 1)
            {
                computerToothpicks = 1;

                toothPicks = toothPicks - computerToothpicks;

                Console.WriteLine($"The computer took {computerToothpicks}"
                    + $" toothpicks. There are {toothPicks}"
                    + " toothpicks left.");
                Console.WriteLine("You win!");
            }
            
        }
 


        
        
    }
}
