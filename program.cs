using System;

namespace DigitalConduct.Fit
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while(keepGoing){
                //Prompt the user for minutes excercised 
                // System.Console.Write("Enter how many minutes you exercided: ");
                Console.Write("Enter how many minutes you exercise or type \'quit\' to exit: ");
                string entry = Console.ReadLine();

                if(entry == "quit"){
                    keepGoing = false;
                    Console.WriteLine("HUA! You've exercised " + runningTotal + " minutes! See You Nextime.");
                }else{
                    int minutes = int.Parse(entry);
                    runningTotal = runningTotal + minutes;
                
                    //Add minutes exercied to total
                    //Display total min excerised on the screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes");
                    //Repeat until the user quits
                }
            }
        }
    }
}