// Sean Kelley
// Lab 7.2
// 16 March 2021

using System;

namespace Lab_7._2_Kelley
{
    public class Project
    {
        static void Main()
        {
            Console.Write("Enter in the number of feet: ");
            int feet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter in the number of inches: ");
            int inches = Convert.ToInt32(Console.ReadLine());

            int finalInches = CalcFeet(feet, inches);

            Console.WriteLine($"{ feet } feet and { inches } inches converts to { finalInches }" +
                $" inches.");
        }

        static int CalcFeet(int inputFeet, int inputInches)
        {
            int totalInches = (inputFeet * 12) + inputInches;
            return totalInches;
        }

    }
}