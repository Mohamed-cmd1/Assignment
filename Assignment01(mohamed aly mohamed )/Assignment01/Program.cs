// 1 
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



//Error 
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

//declare 01  
int pages01 = 300;
double pages02 = pages01;
Console.WriteLine(pages02);
//declare 02  
double price01 = 49.99;
int price02 = (int)price01;
Console.WriteLine(price02);
//convert string to int
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

//ToString
int pages07 = 464;
string pagesText01 = pages07.ToString();
Console.WriteLine(pages07);
Console.WriteLine(pagesText01.GetType());

// boxing and unboxing
int copies01 = 100;
object obj = copies01; //boxing
Console.WriteLine( obj);

object copies02 = 100; 
int copies03 = (int)copies02; //unboxing
Console.WriteLine(copies03);









class Book {
    public string Title;
    public int Pages;

}

