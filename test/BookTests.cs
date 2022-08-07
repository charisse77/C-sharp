using Xunit;
using System; 
using GradeBook; 

namespace test
{
public class BookTests
{
    [Fact] //attribute that tells Xunit which tests to run 
    public void Test1()
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

    }
}

}
/*
dotnet add reference <PROJECT_PATH> : references project on which we want to run tests 
*/