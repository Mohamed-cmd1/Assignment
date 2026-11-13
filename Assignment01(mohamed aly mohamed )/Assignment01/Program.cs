
#region
//1: Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a variable of type object. Print it.
//2: Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
using System.Drawing;

Book book01 = new Book();
book01.Title = "KhanAlKhalili";
book01.Pages = 210;
Book book02 = new Book();
book02.Title = "The Beginning and the End";
book02.Pages = 197;
Console.WriteLine("the title of the book is: " + book01.Title);
Console.WriteLine("the number of pages in the book is: " + book01.Pages);
Console.WriteLine("########################");
Console.WriteLine("the number of pages in the book is: " + book02.Pages);
Console.WriteLine("the title of the book is: " + book02.Title.ToString());
Console.WriteLine("########################");
Console.WriteLine(book01.Title.GetHashCode());
Console.WriteLine(book02.Title.GetHashCode());
Console.WriteLine(book02.Title.GetType());
Console.WriteLine(book01.Pages.GetType());
Console.WriteLine(book02.Pages.GetType());
Console.WriteLine(book01.Equals(book02));
Console.WriteLine("########################");

#endregion 
#region
//3: Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. 
// not int pages ="462"; you can't assign a string to an intvariable
int pages = 464; 
// divid by 0 
int num01 = 10;
int num02 = 0;
try
{
    int result = num01 / num02;
    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally 
{
    Console.WriteLine("Done.");
}
#endregion
#region
//4 + 5 wite code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block
//declare 01  
int pages01 = 300;
double pages02 = pages01;
Console.WriteLine(pages02);
//declare 02  
double price01 = 49.99;
int price02 = (int)price01;
Console.WriteLine(price02);
#endregion
#region
//7 to 10 :Declare a double price = 49.99; then convert it into an int using a cast.


string pagesText = "464";
int pages06 = Convert.ToInt32(pagesText);
Console.WriteLine( pages06);
//parse string to int
String yearText = "2023";
int year = int.Parse(yearText);
Console.WriteLine(year);
//try parse string to int
string badText = "abc";
bool isInvalid = int.TryParse(badText, out int result01);
Console.WriteLine( "Success: " + isInvalid);
Console.WriteLine(result01);
#endregion
#region
//11:Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
int pages07 = 464;
string pagesText01 = pages07.ToString();
Console.WriteLine(pages07);
Console.WriteLine(pagesText01.GetType());
#endregion
#region
//12: Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
// boxing and unboxing
int copies01 = 100;
object obj = copies01; //boxing
Console.WriteLine( obj);

object copies02 = 100; 
int copies03 = (int)copies02; //unboxing
Console.WriteLine(copies03);
#endregion








class Book {
    public string Title;
    public int Pages;

}

