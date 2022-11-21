

namespace _21._11._2022_2
{
    internal class Student : Human
    {
        
        public Student()
        {

        }
        public Student(string name) : base(name)
        {

        }
        public Student(string name, string surname, byte age) : base(name, surname,age)
        {

        }
        public Student(string name, string surname,byte age, double point) : this(name, surname,age)
        {
            this.Point = point;
        }
        public Student(string name, string surname, byte age, double point,double grant) : this(name, surname, age,point)
        {
            this.Grant = grant;
        }




        public double Point;
        public double Grant;




        public void ShowFullData()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age}\n point : {this.Point} grant : {this.Grant}");
        }

        public string GetFUllData() {
            return $"{this.Name} {this.Surname} {this.Age}\n point : {this.Point} grant : {this.Grant}";
        }
    }
}
