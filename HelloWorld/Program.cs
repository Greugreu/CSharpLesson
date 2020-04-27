using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consoles commands
            Console.Write("Foo"); // Display content, on the same line
            Console.Write("Bar");
            Console.WriteLine("Foo");// Display content on a new line
            Console.WriteLine("Bar"); 
            
            // Var String
            string name = "John";
            Console.WriteLine(name);
            
            // Var Int
            int myNum = 15;
            Console.WriteLine(myNum);
            
            // Vars can be changed only by calling it's name if it's already be declared
            myNum = 50;
            Console.WriteLine(myNum);
            name = "Doe";
            Console.WriteLine(name);
            
            // Const are immutable
            const double myFloat = 1.5;
            Console.WriteLine(myFloat);
            // myFloat = 2.5;  Indeed not working
            
            // Concatenation operator
            string lastName = "Doe";
            string fullName = name + " " +lastName;
            Console.WriteLine(fullName);
            
            /* + operator act as a mathematical operator with numbers
             int x = 5;
             int y = 6;
             Console.WriteLine(x + y);  Show the result of 5+6 */
            
            // Can declare multiple variables at the same time
            int x = 5, y = 6, z = 60;
            Console.WriteLine(x + y + z);
            
            /* General variable rules
               Var names are called identifiers, they should be unique. It's better to use descriptive names
               minutesPerHour = 60 GOOD
               m = 60 BAD
               names are case sensitive -> myVar !== myvar
               as most languages, C# has reserved words that can't be used as int, double
            */
            
            // DATA TYPES

            int integer = 5; // from -2,147,483,648 to 2,147,483,647
            float floatNumber1 = 0.12F; // up to 6 to 7 digits
            double floatNumber2 = 1.5; // up to 15 digits, can end with D as 1.5D (but not required)
            long veryLongNumbers = 15000000000L; // from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            bool boolean = true;
            char singleCharacters = 'A';
            string asTheTypeSay = "FooBar";
            
            // floats can also be scientific exponent
            float f1 = 35e3F;
            double d1 = 12E4;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            
            // TYPE CASTING
            // Implicit

            int intVar = 9;
            double doubleCasting = intVar; // automatic int to double casting.
            Console.WriteLine(intVar);
            Console.WriteLine(doubleCasting);
            
            // Explicit

            double doubleVar = 9.78;
            int intCasting = (int) doubleVar; // manual casting double to int.
            Console.WriteLine(doubleVar);
            Console.WriteLine(intCasting);
            
            // It is possible to convert via built-in methods
            bool boolVar = true;
            Console.WriteLine(Convert.ToString(intVar)); // convert to string
            Console.WriteLine(Convert.ToDouble(intVar)); // convert to double
            Console.WriteLine(Convert.ToInt32(doubleVar)); // convert to int
            Console.WriteLine(Convert.ToString(boolVar)); // convert to string
            
            // GET USER INPUT;
            
            

        }
    }
}
