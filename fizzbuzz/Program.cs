using System;
using System.Collections.Generic;
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

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(myFizzystring += three + five);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(myFizzystring += three);
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine(myFizzystring += five);
                }
                
                else
                {
                    Console.WriteLine(i);
                }
                
                //if ( i % 7 == 0 && i % 5 == 0 && i % 3 == 0){
                //    Console.WriteLine("fizzbuzzbang");
                //}
            }
            
            /*String myString = "Fizz";

            myString += "Buzz";
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.Append("Fizz");
            */
        }
    }
}