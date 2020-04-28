using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            // LOOPS
            // IF STATEMENTS
            
            /*
                if (condition)
                {
                    block if true
                }
                else
                {
                    block if false
                }
             
             */

            int test = 12;

            if (test > 10)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            if (test < 10)
            {
                Console.WriteLine(1);
            } 
            else if (test > 20)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }
            
            // ternary operator
            // variable = (condition) ? true : false;

            string result = (test < 10) ? "true" : "false";
            Console.WriteLine(result);
            
            // SWITCH STATEMENT
            
            
        }
    }
}