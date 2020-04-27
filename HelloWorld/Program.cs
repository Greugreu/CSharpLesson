using System;

namespace HelloWord
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
                
        }
    }
}
