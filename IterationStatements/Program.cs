using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();
            //a list is a collecton

            //Create a variable of type int and initialize the variable with a value of 0
            var myNumber = 0;



            // Create a do-while loop
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            // While your variable is less than 100

            do
            {
                myNumber++; //this is the number which is being added. this writes the list for you so you don't have to write each one.

                numbers.Add(myNumber);  //1, 2, 3, 4, to 100

            } while (myNumber < 100);



            // Create a while loop
            // While your variable is less than 200
            while(myNumber < 200)
            {
                // Increment your variable by 1
                myNumber++;
                // Then add your variable to "numbers"
                numbers.Add(myNumber);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach(var item in numbers)  //item is  name you choose to reference each item in numbers (the list)
            {
                Console.WriteLine(item);
                // Console.WriteLine($"{item}"); this for text
                // Console.WriteLine ($"{item} is a number");
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");




            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
                //for (int i = 199; i >=0; i--) don't need <= numbers.count because 199 is established with decrement.
            {
                // Write to the console "numbers" at index i
                Console.WriteLine($"{numbers[i]}");
            }
        }
    }
}
