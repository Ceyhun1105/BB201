

namespace Collections.Models
{
    internal class Library
    {
        List<Book> books=new List<Book>();

        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> BooksByName = new List<Book>();
            foreach(Book book in books)
            {
                if(book.Name.ToLower()==name.ToLower().Trim())
                    BooksByName.Add(book);
            }
            return BooksByName;
        }
        
        public void RemoveAllBooksByName(string name)
        {
            foreach (Book book in books.ToList())
            {
                if (book.Name.ToLower() == name.ToLower().Trim())
                    books.Remove(book);
            }
        }

        public List<Book> SeachBooks(string name)
        {
            bool canchange=int.TryParse(name, out int count);
            List<Book> searchbook= new List<Book>();
            foreach (Book book in books)
            {
                if (book.Name.ToLower() == name.ToLower().Trim())        searchbook.Add(book);
                if (book.AuthorName.ToLower() == name.ToLower().Trim())  searchbook.Add(book);
                if(canchange && count==book.PageCount) searchbook.Add(book);
            }
                return searchbook;
        }

        public List<Book> FindAllBooksByPageCountRange(int first,int last)
        {
            List<Book> booksbycount= new List<Book>();
            foreach(Book book in books)
            {
                if(book.PageCount>=first && book.PageCount <= last)
                {
                    booksbycount.Add(book);
                }
            }
            return booksbycount;
        }

        public Book RemoveBookByCode(string code)
        {
            foreach(Book book in books)
            {
                if(book.Code.ToLower()==code.ToLower().Trim())
                    return book;
            }
            return null;
        }


        public void AddBooks(params Book[] addbooks)
        {
            foreach(Book book in addbooks)
            {
                books.Add(book);
            }
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }


    }
}
