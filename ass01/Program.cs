using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ass01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question 1 
            ////Create a Book class with a Title(string) and Pages(int). Create a Book object and store it
            //// in a variable of type object.Print it.
            //book mybook = new book();
            //mybook.title = "atomic habits";
            //mybook.pages = 300;
            //Console.WriteLine($"Title: {mybook.title}, Pages: {mybook.pages}");
            #endregion

            #region question 2
            //////Using the Book class above, print the result of calling ToString(), Equals() (compare book
            //// with itself), GetHashCode(), and GetType() on book.

            //book mybook = new book();
            //mybook.title = "atomic habits";
            //mybook.pages = 300;
            //Console.WriteLine(mybook.ToString());
            //Console.WriteLine(mybook.Equals(mybook));
            //Console.WriteLine(mybook.GetHashCode());
            //Console.WriteLine(mybook.GetType());
            #endregion

            #region question 3
            ////Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            ////   int pages = "464"; // compile-time error
            //int pages = 464; // fixed
            #endregion

            #region question 4
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            //   divide by zero", and then prints "Done" in a finally block.
            //int x = 10;
            //int y = 0;
            //try 
            //{
            //    int result = x / y;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion

            #region question 5
            ////Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double pagesDouble = pages;
            //Console.WriteLine(pages);
            //Console.WriteLine(pagesDouble);
            #endregion

            #region question 6
            //Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int x = (int)price;
            //Console.WriteLine(price);
            //Console.WriteLine(x);
            #endregion

            #region question 7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            //string text = "464";
            //int x = Convert.ToInt32(text);
            //Console.WriteLine(text);
            //Console.WriteLine(x);
            #endregion

            #region question 8
            ////Given string yearText = "2023";, convert it using int.Parse().Then given string badText =
            ////"abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //// string yeartext = "2023";
            ////int validage = int.Parse(yeartext);
            ////Console.WriteLine(yeartext);
            ////Console.WriteLine(validage);
            ////string badtext = "abc";
            ////bool isparsed = int.TryParse(badtext, out int valid);
            ////if (isparsed == true) {
            ////    Console.WriteLine(valid);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Invalid number");
            /////
            #endregion

            #region question 9 
            //Given int pages = 464;, convert it into a string using ToString() and print its type using
            // GetType() to prove it's now a string.
            //int pages = 464;
            //string invalidpage = pages.ToString();
            //Console.WriteLine(pages);
            //Console.WriteLine(invalidpage);
            //Console.WriteLine(invalidpage.GetType());


            #endregion

            #region question 10 
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            //variable, and print both.
            //int copies = 100;
            //object obj = copies;
            //int newcopies = (int)obj;
            //Console.WriteLine(obj);
            //Console.WriteLine(newcopies);

            #endregion

            #region question 11
            //Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
            //value.
            //int? year = null ;
            //Console.WriteLine(year);
            // year = 2023;
            //Console.WriteLine(year);
            #endregion

            #region question 12
            //Declare a Book? book = null;. Use?.to safely read book.Title without crashing the
            //program, and print the result.
            //book? book = null;
            //string? booktitle = book?.title;
            //Console.WriteLine(booktitle);
            //Console.WriteLine(book?.title ?? "Unknown Title");
            #endregion

            #region question 13
            //string? title = null;
            //Console.WriteLine(title ?? "Untitled");
            //title ??= "Untitled";
            //Console.WriteLine(title);
            #endregion

            #region question 14
            //Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable
            // string confirmedName using the ! operator.
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //Console.WriteLine(confirmedName);
            #endregion


        }
    }
}
