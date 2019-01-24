/*
 * Author: Tracey McCombs
 * Date: January 22, 2019
 * Comment: This C# console application code demonstrates the use of 
 *          conditional statements after receiving input from users
 *          */

using System;

namespace Conditinal_Statement_Grade_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for input

            Console.WriteLine("Enter what final score you think you will get in ISM 4300");

            /*
             *Use the try catch block to validate the user input
             * If the user provides bad input, the catch block 
             * will handle the error and a message will display.
            */
            try
            {
                // this variable will gather the user input
                string input = Console.ReadLine();

                /*
                 *This variable will store the int grade until it is parsed with letter grade
                */
                int numericGrade = int.Parse(input);

                /*
                 * This If/Else If/If statement is used to conditionally test
                 * the user input. Various options are available depending on the amount entered by the user
                */
                if (numericGrade < 60)
                {
                    Console.WriteLine("F");
                    Console.WriteLine("You have a failing grade and will need to re-take the course...");
                }


                else if (numericGrade >= 60 && numericGrade <= 62)
                {
                    Console.WriteLine("D-");
                    Console.WriteLine("You have a failing grade and will need to re-take the course...");
                }

                else if (numericGrade > 62 && numericGrade <= 67)
                {
                    Console.WriteLine("D");
                    Console.WriteLine("You have a failing grade and will need to re-take the course...");
                }

                else if (numericGrade >67 && numericGrade <=69)
                {
                    Console.WriteLine("D+");
                    Console.WriteLine("You have a failing grade and will need to re-take the course...");
                }

                else if (numericGrade >69 && numericGrade <=71)
                {
                    Console.WriteLine("C-");
                    Console.WriteLine("You passed the class by the skin of your teeth and may move on to your next class");
                }

                else if (numericGrade >71 && numericGrade <= 77)
                {
                    Console.WriteLine("C");
                    Console.WriteLine("You passed the class and do not need to re-take the course...");
                }

                else if (numericGrade > 77 && numericGrade <= 79)
                {
                    Console.WriteLine("C+");
                    Console.WriteLine("So close and yet so far, almost a B...You passed the class and do not need to re-take the course...");
                }
                     
                else if (numericGrade >79 && numericGrade <= 81)
                {
                    Console.WriteLine("B-");
                    Console.WriteLine("Good Job! You passed the class and do not need to re-take the course...");
                }
                
                else if (numericGrade >81 && numericGrade <= 87)
                {
                    Console.WriteLine("B");
                    Console.WriteLine("Good Job! You passed the class and do not need to re-take the course...");
                }

                else if (numericGrade >87 && numericGrade <= 89)
                {
                    Console.WriteLine("B+");
                    Console.WriteLine("You're well on your way to getting an A! You passed the class and do not need to re-take the course...");
                }

                else if (numericGrade >89 && numericGrade <= 91)
                {
                    Console.WriteLine("A-");
                    Console.WriteLine("Great Job! You passed the class and do not need to re-take the course...");
                }
                else if (numericGrade >91 && numericGrade <= 97)
                {
                    Console.WriteLine("A");
                    Console.WriteLine("Great Job! You passed the class and do not need to re-take the course...");
                }

                if (numericGrade > 97 && numericGrade <= 100)
                {
                    Console.WriteLine("A+");
                    Console.WriteLine("Excellent Effort! You passed the class! Consider being a GA next semester!");
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            } // end of try
            catch
            {
                Console.WriteLine("Please use an integer less than or equal to 100...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch     
        } // end of static void Main
    } // end of class
} // end of namespace
                   

            
    
