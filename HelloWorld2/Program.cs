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
            // Swtich statement allows to select a block of code to be executed from multiple

            /*
                switch(expression)
                {
                    case x:
                        block of code
                        break;
                    case y:
                        block of code
                        break;
                    default:
                        block of code
                        break;   
                }
             
             the switch expression is evaluated once, the value is compared with the value of each cases,
             if there is a match, the associated block is executed
             */

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // outputs "Thursday" (day 4)
            // the break keyword stops the execution of code and breaks out of switch block.
            // the default keyword is optional and specifies code to run if no match.
            
            // WHILE LOOP
        }
    }
}