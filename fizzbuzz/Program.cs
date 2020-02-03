using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fizzbuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // var myList = new List<string>();
            
            for (int i=1; i <= 100; i++)
            {
                string myFizzystring = "";
                string three = "Fizz";
                string five = "Buzz";
                string seven = "Bang";

                if (i % 3 == 0 && i % 7 == 0)
                {
                    myFizzystring += three + seven + "\n";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    myFizzystring += three + five + "\n";
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    myFizzystring += five + seven + "\n";
                }
                else if (i % 3 == 0)
                {
                    myFizzystring += three + "\n";
                }
                else if (i % 5 == 0)
                {
                    myFizzystring += five + "\n";
                }
                else if (i % 7 == 0)
                {
                    myFizzystring += seven + "\n";
                }
                else
                {
                    Console.WriteLine(i);
                }
                
                
                Console.Write(myFizzystring);

            }
            
            /*String myString = "Fizz";
            myString += "Buzz";
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.Append("Fizz");
            */
        }
    }
}