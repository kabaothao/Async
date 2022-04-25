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
            var task1 = Task.Run(() =>
            {
                Calculate1();
            });

            var task2 = Task.Run(() =>
            {
                Calculate2();
            });

            Task.WaitAll(task1, task2);

            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task1.GetAwaiter();


            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();

            Calculate3(result1, result2);



   

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

        static int Calculate3(int result1, int result2 )
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating result3");
            return result1 + result2;

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