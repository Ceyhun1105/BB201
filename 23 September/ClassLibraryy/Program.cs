using ClassLibraryy.Models;

namespace ClassLibraryy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1= new Book(1,"Marvel","Ted Martin");
            book1.BookCode = book1.Name.Substring(0, 2).ToUpper()+Convert.ToString(1000+book1.Id);
            Book book2 = new Book(2, "Tornodo", "Allan Burg");
            book2.BookCode = book2.Name.Substring(0, 2).ToUpper() + Convert.ToString(1000 + book2.Id);
            Book book3 = new Book(3, "Messi", "Rebert Bill");
            book3.BookCode = book3.Name.Substring(0, 2).ToUpper() + Convert.ToString(1000 + book3.Id);

            Library library = new Library();
            library.Id = 11101;
            library.Name = "Education";
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.ShowAllBooks();

            Console.WriteLine("=====================Filtered for Id=====================");
            foreach (Book book in library.FindBooksById(2))
            {
                book.ShowDetails();
            }
            Console.WriteLine("====================Filtered for BookCode===================");
            foreach (Book book in library.FindBooksByBookCode("ME1003"))
            {
                book.ShowDetails();
            }



        }
    }
}