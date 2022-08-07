using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        //Main method and entry point of the application 
        //args: arguments passed to the application 
        //type of application: string array 
        static void Main(string[] args)
        {
            var book = new Book("School Grade Book"); 
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(92.8);
            book.AddGrade(77.5);
            book.ShowStatistics(); 

       
            

        }
    }
}

/*

*/