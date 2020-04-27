using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
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
            
            //
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);
        }
    }
}
