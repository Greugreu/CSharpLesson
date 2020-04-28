using System;

namespace HelloWorld3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYS
            /*
                Arrays seem to be basically the same as PHP. Used to store multiple values instead of using multiple variables
                to declare an array, define variable type with [] and then use {};
                
                string[] variableName = {}
                int[] variableName = {}
                
                element of an array is accessed by referring to the index number
             */

            string[] animals = {"Giraffe", "Dog", "Cat", "Fish", "Lion", "Monkey", "Bird", "Alpaca", "Horse", "Turtle"};
            // This array will be used for every manipulations
            Console.WriteLine(animals[2]); // As PHP, index starts at 0, so output is "Cat"
            
            // change array element, refer to index number
            animals[8] = "Tiger"; // "Horse" has been replaced by "Tiger"
            Console.WriteLine(animals[8]);
            
            // array length
            Console.WriteLine(animals.Length);
            
            // ARRAY LOOPS
            /*
                as PHP, we can use loops to go through an array.
                We can use for and Length to specify how many times the loop should run
             */

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
            
            // foreach is used exclusively to loop through elements in an array

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}