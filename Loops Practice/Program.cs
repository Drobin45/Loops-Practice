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
            //for (int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Turns a string into an array!!! The following array would be {My, name, is, little, bill.}
            //for loop to print every element of an array from {0} to the {last element}
            //string greeting = "My name is Little Bill.";
            //string[] wordsInGreeting = greeting.Split();            


            //for (int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            // Create an array called days with the elements Monday, tuesday, and Wednesday.
            //Useing a For Loop, print the elements of the day array.
            //Complete!            

            //string days = "Monday Tuesday Wednesday";
            //string[] dayArray = days.Split();

            //for (int i = 0; i < dayArray.Length; i++)
            //{
            //    Console.WriteLine(dayArray[i]);
            //}


            //Start with the string "Once upon a time" and create an array called
            //storyWords using the Split method. reverse the order of the elements in
            //the array and using a For Loop, print each word
            //Complete!

            //string words = "Once upon a time";
            //string[] storyWords = words.Split();
            //Array.Reverse(storyWords);

            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //Add the product (multiplicatoin 1*2*3*4*5*6*etc) of 1 through 10
            //Print the product to screen
            //Complete!


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];             
            //}
            //Console.WriteLine(product);

            //int product = 1;
            //for(int i = 1; i<= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);

            //-----------------------------------------------------------------------------------

            //Foreach loop - used to iterate over a collection(ex. list or array)
            // You can think of the structure of a foreach loop as the statement;
            // For each item in the collection, do something.
            // Always start with the keyword foreach

            //foreach (dataType variable in collection)
            // { do something}

            //int[] studentGrades = { 4, 4, 3, 4, 3 };
            //foreach (int grade in studentGrades)
            //{
            //    Console.WriteLine(grade);
            //}


            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun"};            
            //foreach(string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}


            //  Foreach loops allow the tempmorary variable to "know" to assign...
            //...itself to each element in the collection (like an array), one at a time.

            //Foreach loop will always go from beginning to end, no matter what
            //It counts the number of elemnts in the collection, and runs that number...
            //...of times.


            //create an array of 6 musicians...
            //... using a foreach loop, print each musician's name

            //string[] bands = { "AFI", "Tiger Army", "OMFG", "Slime Girls", "Nujabes", "Childish Gambino" };
            //foreach(string music in bands)
            //{
            //    Console.WriteLine(music);
            //}

            //While loop is used when you want a chunk of code to run only if a...
            //... condition is met first.
            //While something is TRUE, do this thing.(boolian logic)
            //Rarely useful

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            while(firstName.ToUpper() == "DANIEL")
            {
                Console.WriteLine("Dude, you are amazing!");
                break;
            }
                


        }
    }
}
