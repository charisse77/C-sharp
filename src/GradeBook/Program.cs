using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {               
            var book = new Book("School Grade Book");
            book.GradeAdded += OnGradeAdded; 
            book.GradeAdded += OnGradeAdded; 
            book.GradeAdded -= OnGradeAdded; 

          /*  book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);*/

            var done = false; 

            while(!done)
            {
                System.Console.WriteLine("Please enter a grade or 'q' to quit.");
                var input = Console.ReadLine(); 
                if(input == "q")
                {
                    done = true; 
                    continue; 
                }

            try
            {
                var grade = double.Parse(input); 
                book.AddGrade(grade); 
            }
            catch(ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
                throw; 

            }
            catch(FormatException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                System.Console.WriteLine(("**"));

            }
                
            }
            
            
            
            
            var stats = book.GetStatistics();         
            
            System.Console.WriteLine(Book.CATEGORY);
            System.Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");            
        } 

        static void OnGradeAdded(object sender, EventArgs e)
        {
            System.Console.WriteLine($"A grade was added!");


        }       
    }
}

/*
Reference Type
var b = new ook("Grades");
- b holds a reference type (object) stored at specific location in memory  

Value Type
var x = 3; 
- x holds 3 which is an int and at a value type 

*/