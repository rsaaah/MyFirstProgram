using System;// Ken Programming class
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5; 
            if (x > 10)
            {
                Console.WriteLine("The number is large!.");//false 5 is not > 10 
            }
            else // when statement above is False code checks below statement for true/false
            {
                Console.WriteLine("Oops. Low number!");// if 5 is < 10 prints "Oops. Low number!"
            }
            Console.WriteLine("What is your name?"); // user sees this message
            string userName = Console.ReadLine(); // reads user input
            Console.WriteLine("Hello " + userName + "!"); //welcomes user input
            int y = 0;
            while (y <= 5) // true statement so code below may run 0 is <= to 5
            {
                Console.WriteLine(y);//writes y value once
                y++; //makes number go up to while statement
            }
        }
    }
}
