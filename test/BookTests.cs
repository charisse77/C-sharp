using Xunit;
using System; 
using GradeBook; 

namespace test
{
public class BookTests
{
    [Fact]
    public void BookGradeIsValid()
    {
        var book = new Book("");
        
        Assert.Throws<ArgumentException>(() => book.AddGrade(101)); 
        
    }
   

    [Fact] //attribute that tells Xunit which tests to run 
    public void BookCalculatesAnAverageGrade()
    {
        //arrange 
        var book = new Book(""); //initialize class Book 
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        //act - do something that produce a result 
        var result = book.GetStatistics(); 

        //assert something about value computed inside of act 
        Assert.Equal(85.6, result.Average,1); //Assert.Equal(expected, actual, precision value)
        Assert.Equal(90.5, result.High,1); 
        Assert.Equal(77.3, result.Low,1); 
        Assert.Equal('B',result.Letter); 

    }
}

}
/*
dotnet add reference <PROJECT_PATH> : references project on which we want to run tests 
dotnet new sln: create new solution 
dotnet sln add src\GradeBook\GradeBook.csproj 
dotnet sln add test\test.csproj : add all files to a single solution file to build all projects at same time 
*/