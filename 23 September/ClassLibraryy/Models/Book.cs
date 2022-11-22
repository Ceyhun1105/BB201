
namespace ClassLibraryy.Models
{
    internal class Book
    {
        public Book(int id, string name, string authorname)
        {
            Id = id;
            Name = name;
            AuthorName = authorname;
        }

        public string BookCode;
        private int _id;
        private string _name;
        private string _authorName;
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
                if (!String.IsNullOrWhiteSpace(value) && value.Length>2)
                {
                    _name=value;
                }
            }
        }
        public string AuthorName
        {
            get { return _authorName; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length >= 2)
                {
                    _authorName=value;
                }
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine($" Id : {Id}\n Name : {Name}\n Author : {AuthorName}\n Code : {BookCode}\n");
        }
        

    }
}
