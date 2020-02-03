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

                if (i % 3 == 0 && i % 5 == 0)
                {
                    myFizzystring += "fizz" + "buzz";
                    Console.WriteLine(myFizzystring);
                }
                else if (i % 3 == 0)
                {
                    myFizzystring += "fizz";
                    Console.WriteLine(myFizzystring);
                }

                else if (i % 5 == 0)
                {
                    myFizzystring += "buzz";
                    Console.WriteLine(myFizzystring);
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