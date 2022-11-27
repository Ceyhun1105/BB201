
namespace UserCheckPassword
{
    internal class Student
    {
        static int i = 1;
        public Student(string fullname, double point)
        {
            FullName = fullname;
            Point = point;
            Id = i;
            i++;
        }
        public int Id { get; private set; }

        private string _fullname;
        public string FullName
        {
            get => _fullname;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length > 6)
                    _fullname = value;
            }
        }

        private double _point;
        public double Point
        {
            get => _point;
            set
            {
                if (value > 0 && value < 100)
                {
                    _point = value;
                }
            }
        }

        public void StudentInfo()
        {
            Console.WriteLine($"\n Id : {Id}   Full Name : {FullName}   Point : {Point}");
        }
    }
}
