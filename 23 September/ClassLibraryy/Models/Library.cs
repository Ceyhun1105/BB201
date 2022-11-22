

using System.Security.Cryptography;
using System.Xml.Linq;

namespace ClassLibraryy.Models
{
    internal class Library
    {
        private int _id;
        private string _name;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id=value;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length > 2)
                {
                    _name=value;
                }
            }
        }

        Book[] books = Array.Empty<Book>();

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length+1);
            books[books.Length-1] = book;
        }
        public void AddBook( ref Book[] books, Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }
        public void RemoveBook(Book book)
        {
            Array.Resize(ref books, books.Length - 1);
        }
        public void ShowAllBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine($" Id : {book.Id}\n Name : {book.Name}\n Author : {book.AuthorName}\n Code : {book.BookCode}\n");
            }
        }
        public Book[] FindBooksById( int id)
        {
            Book[] newbook= Array.Empty<Book>();
            foreach(Book book in books) 
            { 
                if (book.Id == id)
                {
                    AddBook(ref newbook,book);
                }
                
            }
            return newbook;
        }

        public Book[] FindBooksByBookCode(string bookcode)
        {
            Book[] bookForBookCode = Array.Empty<Book>();
            foreach (Book book in books)
            {
                if (book.BookCode.ToLower() == bookcode.ToLower())
                {
                    AddBook(ref bookForBookCode, book);
                }

            }
            return bookForBookCode;
        }


    }

}
