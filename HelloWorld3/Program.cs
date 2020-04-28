using System;
using System.Linq;

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
            
            // to sort an array, method sort() allows to sort alphabetically or ascending order
            Array.Sort(animals);
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            
            // other methods can be found in System.Linq (we added new object use) as Min, Max, Sum
            int[] numbers = {5, 4, 6, 8, 9, 12, 7, 3, 56};
            Console.WriteLine(numbers.Max()); // returns largest value
            Console.WriteLine(numbers.Min()); // returns smallest value
            Console.WriteLine(numbers.Sum()); // returns sum of elements
            
            // DIFFERENT WAYS TO CREATE ARRAYS
            
            // create an array of four elements, and add values later
            string[] fruits = new string[4];
            
            // create an array of four elements and add values right away
            string[] fruits2 = new string[4] {"Apple", "Banana", "Coconut", "Watermelon"};
            
            // create an array of four elements without specifying it's size
            string[] fruits3 = new string[] {"Apple", "Banana", "Coconut", "Watermelon"};
            
            // create an array as before
            string[] fruits4 = {"Apple", "Banana", "Coconut", "Watermelon"};
            
            // however, to create an empty array and add values later, need to use "new" keyword.
            string[] fruits5;
            // fruits5 = {"Apple", "Banana", "Coconut", "Watermelon"}; not working
            fruits5 = new string[] {"Apple", "Banana", "Coconut", "Watermelon"}; // working
            
            // END ARRAYS NEXT METHODS AND POO IN NEW REPOS CSharpPOO
        }
    }
}