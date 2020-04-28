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
            /*
                Allow a block of code to run as long as the condition is true
                
                while (condition)
                {
                    code
                }
                
             */

            int i = 0;
            while (i<5)
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
            }
            
            // DO WHILE
            /*
                do/while is a variant of while. It will execute code once, before checking if condition is true
                then repeat the loop as long as it is true
                
                do
                {
                    code
                }
                while (condition)
             */
            int a = 0;
            do
            {
                Console.WriteLine("Value of a: {0}", a);
                a++;
            }
            while (a < 5);
            
            // FOR LOOP
            /*
                for (statement 1; statement 2; statement 3)
                {
                    code
                }
             */

            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine("Value of b: {0}", b);
            }

            for (int c = 0; c <= 10; c = c + 2)
            {
                Console.WriteLine("Value of c: {0}", c);
            }
            
            // FOREACH
            /*
                forcheach (type variableName in arrayName)
                {
                    code
                }
             */

            string[] cars = {"Audi", "Tesla", "Ford", "Mazda"};
            foreach (string d in cars)
            {
                Console.WriteLine(d);
            }
            
            // BREAK/CONTINUE STATEMENT
            /*
                as already seen, the break statement is used to stop a loop. But it can also be used to jump out of a loop
             */

            for (int e = 0; e < 10; e++)
            {
                if (e == 4)
                {
                    break;
                }
                Console.WriteLine(e);
            }
            
            /*
                the continue can be used to break a loop when condition is met and continue on the next loop iteration 
                break and continue can be used in while loops            
             */

            for (int f = 0; f < 10; f++)
            {
                if (f == 4)
                {
                    continue;
                }
                Console.WriteLine(f); // 4 is skipped
            }
            
            // END LOOPS
            // NEXT ARRAYS IN HELLOWORLD3
        }
    }
}