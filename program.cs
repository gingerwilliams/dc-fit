using System;

namespace DigitalConduct.Fit
{
    class Program
    {
        static void Main()
        {
            //Prompt the user for minutes excercised 
            // System.Console.Write("Enter how many minutes you exercided: ");
            Console.Write("Enter how many minutes you exercided: ");
        
            string entry = Console.ReadLine();
            //Add minutes exercied to total
            //Display total min excerised on the screen
            Console.WriteLine("You've exercised " + entry + " min");
            //Repeat until the user quits
        }
    }
}