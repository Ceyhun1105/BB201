

namespace UserCheckPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string surname = string.Empty;
            string password = string.Empty;
            string email = string.Empty;
            bool check = false;
            bool check1 = false;
            do
            {
                Console.Clear();
                Console.Write(" Name : ");
                name = Console.ReadLine();
                Console.Write(" Surname : ");
                surname = Console.ReadLine();
                check = string.IsNullOrWhiteSpace(name);
                check1 = string.IsNullOrWhiteSpace(surname);
            } while (check | check1 | name.Length < 3 | surname.Length < 3);


            Console.Write("\n Password must be contain :\n" +
                " least 1 digit\n least 1 uppercase letter\n least 1 lowercase letter\n" +
                " Else, random password will created. You can see in ShowInfo menu\n Password : ");
            password = Console.ReadLine();
            Console.Write(" E-mail : ");
            email = Console.ReadLine();


            User user = new User(email, password);
            user.FullName = name + " " + surname;
            Console.Clear();

            bool finish = false;
            do
            {
                
                Console.Write("\n Press S - Show Info \n Press C - Creat new group \n Press Q - Quit\n Please Press One : ");

                var press = Console.ReadKey();



            turnhere:
                switch (press.Key)
                {
                    case ConsoleKey.S:
                        Console.WriteLine();
                        user.ShowInfo();
                        Console.WriteLine($" Password : {user.Password}");
                        break;
                    case ConsoleKey.C:
                        string No;
                        int limit;
                        bool checkgroup = false;
                        do
                        {
                            Console.Clear();
                            Console.Write(" Enter the Gruop Number (Example : AA123) : ");
                            No = Console.ReadLine();
                            Console.Write(" Enter Students limit number (min:5 , max:18) : ");
                            limit = Convert.ToInt32(Console.ReadLine());
                            if (char.IsUpper(No[0]) && char.IsUpper(No[1]) && char.IsDigit(No[2])
                    && char.IsDigit(No[3]) && char.IsDigit(No[4])) checkgroup = true;
                        } while (string.IsNullOrWhiteSpace(No) || limit < 5 || limit > 18 | !checkgroup);

                        Group group = new Group(No, limit);
                        string choice;
                        do
                        {
                            Console.Clear();

                            Console.Write(" 1 - Show All Students\n 2 - Get Student By Id\n 3 - Add Student to Group\n 0 - Quit\n Enter your Choice : ");

                            choice = Console.ReadLine();

                            switch (choice)
                            {

                                case "1":
                                    if (group.GetAllStudent().Length > 0)
                                    {
                                        foreach (Student studentss in group.GetAllStudent())
                                        {
                                            studentss.StudentInfo();
                                        }
                                        Console.WriteLine("\n Loading...");
                                    }
                                    else
                                    {
                                        Console.WriteLine(" Group is Empty");
                                    }
                                    break;

                                case "2":
                                    if (group.GetAllStudent().Length > 0)
                                    {
                                        Console.Write(" Which Id are you looking for ?\n If you enter wrong Id it returns last Student. Answer : ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        group.GetStudent(id).StudentInfo();
                                        Console.WriteLine("\n Loading...");
                                    }
                                    else
                                    {
                                        Console.WriteLine(" Group is Empty");
                                    }
                                    break;

                                case "3":
                                    bool check2;
                                    string point;
                                    string namee;
                                    string surnamee;
                                    int pointt;
                                    do
                                    {
                                        Console.Write(" Name : ");
                                        namee = Console.ReadLine();
                                        Console.Write(" Surname : ");
                                        surnamee = Console.ReadLine();
                                        Console.Write(" Point : ");
                                        point = Console.ReadLine();
                                        check = string.IsNullOrWhiteSpace(name);
                                        check1 = string.IsNullOrWhiteSpace(surname);
                                        check2 = int.TryParse(point, out pointt);
                                    } while (check | check1 | !check2 | namee.Length < 3 | surnamee.Length < 3 | pointt < 0 | pointt > 100);
                                    string fullname = namee + " " + surnamee;
                                    Student student1 = new Student(fullname, pointt);
                                    Console.Write(" "+student1.FullName + " , ");
                                    group.AddStudent(student1);
                                    Console.WriteLine($" Group {group.GroupNo} Loading...");
                                    break;
                                case "0":
                                    Console.WriteLine(" Return Home Menu ...");
                                    break;
                                default:
                                    Console.WriteLine(" Wrong Choice ");
                                    break;
                            }

                            Thread.Sleep(3000);
                        } while (choice != "0");

                        break;

                    case ConsoleKey.Q:
                        finish = true;
                        break;

                    default:
                        Console.Write("\n Wrong Press , Press again : ");
                        press = Console.ReadKey();
                        goto turnhere;

                }
            } while (!finish);


        }
    }
}