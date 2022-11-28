


namespace UserCheckPassword
{
    internal class Group
    {

        public Group(string groupno, int limit)
        {
            GroupNo = groupno;
            StudentLimit = limit;
        }
        public string _groupno;
        public string GroupNo
        {
            get => _groupno;
            set
            {
                if (checkGroupNo(value)) _groupno = value;
            }
        }

        private int _studentlimit;
        public int StudentLimit
        {
            get => _studentlimit;
            set
            {
                if (value > 4 && value < 19) _studentlimit = value;
            }
        }

        Student[] students = Array.Empty<Student>();


        public bool checkGroupNo(string groupNo)
        {
            if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2])
                && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
            {
                return true;
            }
            return false;
        }

        static int count = 0;


        public void AddStudent(Student student)
        {
            if (count < StudentLimit)
            {
                Console.WriteLine(" You are adding to Group...");
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
                count++;
            }
            else
            {
                Console.WriteLine(" Sorry , Group is Full ...");
            }
        }

        public Student GetStudent(int id)
        {
            foreach (Student student in students)
            {
                if (student.Id == id)
                    return student;
            }
            return students[students.Length-1];
        }

        public Student[] GetAllStudent()
        {
            return students;
        }

    }
}
