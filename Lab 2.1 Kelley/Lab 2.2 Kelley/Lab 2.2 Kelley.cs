/*
 * lab 2.2
 * Sean Kelley
 * 1 February 2022
 */

using System;

class Name
{
    static void Main()
    {
        Console.WriteLine("Enter the name of your first friend: ");
        var firstFriend = Console.ReadLine();

        Console.WriteLine("Enter the name of your second friend: ");
        var secondFriend = Console.ReadLine();

        Console.WriteLine("The calculation " + firstFriend + " > " + secondFriend + " is " + firstFriend.CompareTo(secondFriend) + ".");
    }
}