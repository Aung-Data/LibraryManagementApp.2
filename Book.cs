using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementApp._2
{
    public class Book
    {
        //Book class field
        private string bookID;
        private string bookTitle;
        private string author;
        private int yearEstablished;
        private int numberOfCopies;

        //Book Class Properties
        public string BookID { get { return bookID; } set { bookID = value; } }
        public string BookTitle { get { return bookTitle; } set { bookTitle = value; } }
        public string Author { get { return author; } set { author = value; } }
        public int YearEstablished { get { return yearEstablished; } set { yearEstablished = value; } }
        public int NumberOfCopies { get { return numberOfCopies; } set { numberOfCopies = value; }  }

        //Book Class Constructors
        public Book(string id, string title, string  author, int yearEstablished, int copies)
        {
            BookID = id;
            BookTitle = title;
            Author = author;
            YearEstablished = yearEstablished;
            NumberOfCopies = copies;

        }

        //Book class methods
        //DisplayBook method
        public void DisplayBook()
        {
            Console.WriteLine("==========Book Details==========");
            Console.WriteLine("==================================");
            Console.WriteLine($"Book ID: \t\t{BookID}");
            Console.WriteLine($"Title: \t\t\t{BookTitle}");
            Console.WriteLine($"Author: \t\t{Author}");
            Console.WriteLine($"Year Established: \t{YearEstablished}");
            Console.WriteLine($"Copies Available: \t{NumberOfCopies}");
            Console.WriteLine("==================================");
        }

        //BorrowBook Method
        public void BorrowBook()
        {
            if (NumberOfCopies > 0)
            {
                NumberOfCopies--;

                Console.WriteLine($"You have successfully borrowed {BookID} - {BookTitle}.");
                Console.WriteLine($"Remaining copies: {NumberOfCopies}");
            }
            else
            {
                Console.WriteLine($"Sorry, {BookTitle} is currently not available.");
            }
        }
       
        //Return Book Method
        public void ReturnBook()
        {
            NumberOfCopies++;

            Console.WriteLine($"You have successfully returned {BookID} - {BookTitle}.");
            Console.WriteLine($"Available copies: {NumberOfCopies}");
        }
    }
}
