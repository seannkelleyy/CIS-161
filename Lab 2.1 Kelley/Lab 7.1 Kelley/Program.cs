// Sean Kelley
// Lab 7.2
// 15 March 2021

using System;

namespace Lab_7._1_Kelley
{
    public class Project
    {
        static void Main()
        {
            Console.Write("Enter in the number of inches: ");
            int userInches = Convert.ToInt32(Console.ReadLine());

            CalcFeet(userInches);
        }

        private static void CalcFeet(int inputInches)
        {
            
            int feet = inputInches / 12;
            int inches = inputInches % 12;
            Console.WriteLine($"{ inputInches } inches converts to { feet }" +
                $" feet and { inches } inches.");
        }

    }
}