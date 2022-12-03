using Collections.Models;
using System.Runtime.InteropServices;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new("India Story", "Bimal Jalal", 245);
            Book book2 = new("Listen to Your Heart", "Ruskin Bond", 230);
            Book book3 = new("Business of Sports", "Vinit Karnik", 342);
            Book book4 = new("Place Called Home", "Preeti Shenoy", 230);
            Book book5 = new("Leaders, Politicians, Citizens", "Preeti Shenoy", 342);
            Book book6 = new("Birsa Munda – Janjatiya Nayak", "Rajnath Singh", 135);
            Book book7 = new("Queen of Fire", "Rasheed Kidwai", 156);
            Book book8 = new("TThe Maverick Effect", "Smriti Irani", 340);
            Book book9 = new("Hear Yourself", "Shashi Tharoor", 245);
            Book book10 = new("Hear Yourself", "Devika Rangachari", 245);


            Library library = new Library();
            library.AddBooks(book1,book2,book3,book4,book5,book6,book7,book8,book9,book10);

            // Check Book Code  
            ResetColor(" Book Codes");
            foreach (Book book in library.GetAllBooks())
            {
                Console.WriteLine(" "+book.Code);
            }

            Console.WriteLine();

            // Show All Books
            ResetColor(" All Books");
            foreach (Book book in library.GetAllBooks())
            {
                Console.WriteLine("\n" + book);
            }


            // Search Books By name or authorname or countpage

            ResetColor(" Searching books");
            foreach (Book book in library.SeachBooks("245"))
            {
                Console.WriteLine("\n" + book);
            }



            // Find All Books By Name
            ResetColor(" Books by Name");
            foreach (Book book in library.FindAllBooksByName("Hear Yourself"))
            {
                Console.WriteLine("\n" + book);
            }


            // Remove Books By Name
            ResetColor(" Books Removed By Name");
            Console.WriteLine(" Before Romeved List Length : "+library.GetAllBooks().Count);
            library.RemoveAllBooksByName("Hear Yourself");
            Console.WriteLine(" After Romeved List Length : " + library.GetAllBooks().Count);

            // Remove Book by Code
            ResetColor(" Remove Book By Code");
            Console.WriteLine(" Before Romeved List Length : " + library.GetAllBooks().Count);
            library.GetAllBooks().Remove(library.RemoveBookByCode("pl4"));
            Console.WriteLine(" After Romeved List Length : " + library.GetAllBooks().Count);

            // Find book by page count range two number
            ResetColor(" Find books by pagecount amount two number");
            foreach (Book book in library.FindAllBooksByPageCountRange(180, 310))
            {
                Console.WriteLine("\n"+book);
            }


            void ResetColor(string sentence)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine(sentence);
                Console.ResetColor();
            }

        }

        
    }
}