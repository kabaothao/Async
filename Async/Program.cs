// See https://aka.ms/new-console-template for more information


using System;

namespace Async // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }

        static void Calculate() 
        {
            Calculate1();
            Calculate2();
            Calculate3();

        }

        static int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating result1");
            return 100;
        }

        static int Calculate2()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating result2");
            return 200;

        }

        static int Calculate3()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating result3");
            return 300;

        }
    }
}





/* 
 *
 * Synchroonous Program Execution

 In a synchronous program execution model,

program is executed line by line, one at a time.

When a function is called,

programming execution has to wait until

the function returns before it continues execution to the next line.


* When a function is called, program execution continues to the next line, without waiting for the function to complete.
* Asynchronous programming model improves responsiveness of your application.
* Real world experiences: Windows Media Player, Web Browser


When to use asynchronous?
    * Accessing the Web
    * Working with files and databases
    * Working with images
    * So how do we do that in C#?




We had 2 approaches 
    * 1. mulitthreading
    * callback methods

    * Microsoft introduced a new asynchronous programming model,

    which is called Task-based Asynchronous Model.

    And we achieved that by using async and await keywords.

    And that's the topic of this lecture.


*
 




 */