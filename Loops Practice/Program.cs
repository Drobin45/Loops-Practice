using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //when would you use a loop?
            //Why would you use a loop?
            //Loops we will be discussing:
            //For loops, Foreach loops, while loops, do-while loops, and nested loops
            //Infinite loops
            //keywords break and continue

            //For Loop 
            //Can be used for counting and iterating through an array (or other collection of type)
            // Looks like this:
            //for(initializer; condition; updater)
            //{
            //      Do something
            //}

            //Two examples of a for loops

            //for (int i = 0; i <= 10; i++)
            //{                
            //    Console.WriteLine(i);
            //}

            // 'i' here exists outside the loop. However, this is considered bad practice

            //int i;
            //for (i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("After the loop has run, i now has the value of" + i);

            //Count from 50 to 100
            for (int i = 50; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
