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

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();

            //while(firstName.ToUpper() == "DANIEL")
            //{
            //    Console.WriteLine("Dude, you are amazing!");
            //    break;
            //}

            //Console.WriteLine("Do you want to play a game? YES/NO");
            //string playAgain = Console.ReadLine().ToUpper();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}


            //Do-while loops
            //A Do-while loop is simily to a while loop, however a Do-while loop is used...
            //... when you want a chunk of code to run at least once but repeat only if the while...
            //... condition is met.

            //the structure of a Do -while loop looks like this
            // do
            //{
            //    Does a thing
            //}
            //while (condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");

            //    //let's pretend the code for the game is here  

            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want ot play again? YES/NO");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");


            // ask the user for the class (in school) that they would like to add to their GPA calculation
            // ask the user for the letter grade for the class (no + or -)
            // ask the user if they have another class they would like to add to their GPA calculation
            //Using a Do-While loop, repeat the code if the user says "YES".

            //string newClass;
            //do
            //{
            //    Console.WriteLine("What class would you like to add to your GPA calculation?");
            //    string course = Console.ReadLine();

            //    Console.WriteLine("What is the letter grade for your class?");
            //    string grade = Console.ReadLine();

            //    Console.WriteLine("Would you like to add another class?");
            //    newClass = Console.ReadLine().ToUpper();
            //}
            //while (newClass == "YES");

            //-----------------------------------------------------------------------------------

            //Nested loops: A loop in a loop!
            //Inner loop is executed more times than the outer loop
            // Real life example: Clock

            // Create a nested loop structure that prints:
            //2 rows/4 colums
            // 1234
            // 1234

            //for (int rows = 1; rows <= 2; rows++)
            //{
            //    for (int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            // Print a triangle
            // Outer loop will go line by line
            //The inner loop will go over different elements in the line.
            //Result:
            //1
            //12
            //123
            //1234 .....

            //for (int rows = 1; rows <= 20; rows++)
            //{
            //    for (int columns = 1; columns <= rows; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //------------------------------------------------------------------------------------

            // Homework 1
            //Write a program that takes your favorite foods and prints them out one at a time. (Use a foreach loop.)
            // Complete!

            //string[] foods = { "eggs", "toast", "pancakes", "oatmeal", "waffles" };

            //foreach (string favorites in foods)
            //{
            //    Console.WriteLine(favorites);
            //}


            // Homework 2
            //Creat an array of lucky numbers. Using a foreach loop, print out the following:
            // "Your lucky number is: #" 
            // Do this for five numbers.
            // Complete!

            //int[] numbers = { 7, 9, 13, 11, 19, 2 };
            //foreach (int lucky in numbers)
            //{
            //    Console.Write("Your lucky number is ");
            //    Console.WriteLine(lucky);
            //}


            //Homework 3
            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            //Complete!            

            //Counts to 60 by 5's
            //for (int i = 0; i < 5; i += 5)
            //{
            //    for (i = 5; i <= 60; i += 5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Allows user to decide what kind of multiplaction tables. 
            //int multNum = 1;
            //Console.WriteLine("Enter in your first number");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter in your second number");
            //int secondNumber = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= firstNumber; i ++)
            //{
            //    for(int j = 1; j<= secondNumber; j++)
            //    {
            //        Console.WriteLine(multNum * j + " ");                    
            //    }
            //    multNum += 1;
            //    Console.WriteLine();
            //}

            //Homework 4
            //Create an array of your favorite movies....
            //...Print out each movie in the list, unless the move starts with a vowel. Hint: Research.startsWith()



                //Homework 5
                //Write a console application that asks the user for an integer. 
                //If that integer is evenly divisible by 3, then write “You Won!” 
                //If it isn’t, write “You Lost.” Keep asking them for a number (looping)until they win.







        }
    }
}
