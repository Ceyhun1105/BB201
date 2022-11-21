

namespace _21._11._2022_2
{
    internal class Teacher : Human
    {
        

        public Teacher()
        {

        }
        public Teacher(string name) : base(name)
        {

        }
        public Teacher(string name, string surname) : base(name, surname)
        {

        }



        public string Professions;
        public double Experience;



        public void ShowFullData() {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age}\n Profession : {this.Professions} Experience : {this.Experience} year");
        }
    }
}
