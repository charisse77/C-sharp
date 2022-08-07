using Xunit;
using System; 
using GradeBook; 

namespace test
{
public class TypeTests
{
    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
       string name = "Mary";
       MakeUppercase(name); 


        Assert.Equal("Mary",name);
        
    }

        private void MakeUppercase(string name)
        {
           name.ToUpper(); 
        }

        [Fact]
    public void ValueTypesAlsoPassByValue()
    {
        var x = GetInt();
        SetInt(ref x); 
        Assert.Equal(42,x);
    }

        private void SetInt(ref int x)
        { //method can change x variable by passing by reference 
            x = 42; 
        }

        private int GetInt()
    {
        return 3; 
    }

    [Fact] //attribute that tells Xunit which tests to run 
    public void CSharpCanPassByRef()
    {
        //arrange 
       var book1 = GetBook("Book 1"); 
       GetBookSetName(ref book1, "New Name"); 

        //act - do something that produce a result 
      

        //assert something about value computed inside of act 
        Assert.Equal("New Name",book1.Name);
        
        
    }

        private void GetBookSetName(ref Book book, string name)
        { //passing by reference 
            book = new Book(name); 
            book.Name = name; 
        }
    [Fact] //attribute that tells Xunit which tests to run 
    public void CSharpIsPassByValue()
    {
        //arrange 
       var book1 = GetBook("Book 1"); 
       GetBookSetName(book1, "New Name"); 

        //act - do something that produce a result 
      

        //assert something about value computed inside of act 
        Assert.Equal("Book 1",book1.Name);
        
        
    }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name); 
            book.Name = name; 
        }

    [Fact] //attribute that tells Xunit which tests to run 
    public void CanSetNameFromReference()
    {
        //arrange 
       var book1 = GetBook("Book 1"); 
       SetName(book1, "New Name"); 

        //act - do something that produce a result 
      

        //assert something about value computed inside of act 
        Assert.Equal("New Name",book1.Name);
        
        
    }

        private void SetName(Book book, string name)
        {
            book.Name = name; 
        }

        [Fact] //attribute that tells Xunit which tests to run 
    public void GetBookReturnsDifferentObjects()
    {
        //arrange 
       var book1 = GetBook("Book 1"); 
       var book2 = GetBook("Book 2");

        //act - do something that produce a result 
      

        //assert something about value computed inside of act 
        Assert.Equal("Book 1",book1.Name);
        Assert.Equal("Book 2",book2.Name);
        Assert.NotSame(book1,book2);
        
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        //arrange 
       var book1 = GetBook("Book 1"); 
       var book2 = book1;

        //act - do something that produce a result 
      

        //assert something about value computed inside of act 
        Assert.Same(book1,book2); //asks if the values inside these variables are pointing to the same object if so ReferenceEquals would return true 
        Assert.True(Object.ReferenceEquals(book1,book2)); //asks if the values inside these variables are pointing to the same object if so ReferenceEquals would return true 
        
    }

        Book GetBook(string name)
        {
            return new Book(name); 
        }
    }

}
/*
dotnet add reference <PROJECT_PATH> : references project on which we want to run tests 
dotnet new sln: create new solution 
dotnet sln add src\GradeBook\GradeBook.csproj 
dotnet sln add test\test.csproj : add all files to a single solution file to build all projects at same time 

string is a reference type even thought it behaves like a value type 
struct keyword: special that needs to behave like a value type that requires small amounts of memory and can be more efficient than class keyword 
*/