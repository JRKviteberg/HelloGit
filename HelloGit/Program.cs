﻿namespace HelloGit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Git!");
        Console.WriteLine("My name is JR");

        CountTo(num: 5);
    }
    
    // <Summary>
    // This method counts to the number specified
    // </summary>
    // <param Name="numb"> The number to count until.</param>
    static void CountTo(int num)
    {
        Console.WriteLine($"Counting to {num}");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine( i + " ... ");
        }
    }
}