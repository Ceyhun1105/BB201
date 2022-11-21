namespace _21._11._2022_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creat Human object called human1
            Human human1 = new Human()
            {
                Name = "Farid",
                Surname = "Agayev",
                Age = 19
            };

            Console.WriteLine(human1.GetFullData());
            human1.ShowFullData();

            // Creat Teacher object called teacher1
            Teacher teacher1 = new Teacher()
            {
                Name = "Azer",
                Surname = "Aliyev",
                Age = 34,
                Experience = 5,
                Professions = "Chemistry"
            };
            Console.WriteLine(teacher1.GetFullData());
            teacher1.ShowFullData();

            // Creat Student object called student1

            Student student1 = new Student();
            student1.Name = "Ceyhun";
            student1.Surname = "Farzullayev";
            student1.Age = 19;
            student1.Point = 89;
            student1.Grant = 176;

            Console.WriteLine(student1.GetFullData());
            student1.ShowFullData();


            Student student2 = new Student("Ahad", "Valizade",18, 90, 154);
            student2.ShowFullData();



            Student student3 = new Student();
            student3.Name = "Azer";
            student3.Surname = "Rzazade";
            student3.Age = 23;
            student3.Point = 67.3;
            student3.Grant = 154.4;

            Console.WriteLine(student3.Grant);
            Console.WriteLine(student3.Point);








        }
    }
}