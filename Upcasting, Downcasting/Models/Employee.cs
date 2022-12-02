
namespace Upcasting__Downcasting.Models
{
    internal class Employee : IPerson
    {
        public static int counter;
        public int Id { get; }  // public int Id { get ; private set; }

        public string Name { get; set; }

        public byte Age { get; set; } 

        public double Salary { get; set; }

        public string GetInfo()
        {
            return $" Id : {Id} Name : {Name}\n Age : {Age}\n Salary : {Salary}";
        }
        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
        public override string ToString()
        {
            return GetInfo();
        }

        public Employee()
        {
            counter = 0;
        }
        public Employee(string name, byte age , double salary)
        {
            
            Id = ++counter; 
            Name = name; 
            Age = age; 
            Salary = salary;
        }
    }
}
