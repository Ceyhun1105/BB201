

namespace _21._11._2022_2
{
    internal class Human
    {
        public Human()
        {

        }
        public Human(string name)
        {
            this.Name = name;
        }
        public Human(string name, string surname) : this(name)
        {
            this.Surname = surname;
        }
        public Human(string name, string surname, byte age) : this(name, surname)
        {
            Age = age;
        }

        public string Name;
        public string Surname;
        public byte Age;


        public void ShowFullData()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age}");
        }
        public string GetFullData()
        {
            return $"{this.Name} {this.Surname} {this.Age}";
        }


        



    }
}
