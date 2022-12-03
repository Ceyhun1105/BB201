

using System.Data;

namespace Collections.Models
{
    internal class Book
    {
        static int _counter;

        public string Name { get; set; }
        
        public string AuthorName { get; set; }

        public int PageCount { get; set; }

        public string Code { get; set; } 

        public Book(string name, string authorname, int count)
        {
            _counter++;
            Name = name;
            AuthorName=authorname;
            PageCount=count;
            Code= Name.Trim().Substring(0, 2).ToUpper() + _counter.ToString();
        }

        public override string ToString()
        {
            return $" Name : {Name}\n Author Name : {AuthorName}\n Code : {Code}\n Number of Page : {PageCount}";
        }

    }
}
