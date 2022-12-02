using Upcasting__Downcasting.Exceptions;
using Upcasting__Downcasting.Models;

namespace Upcasting__Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Aygun", 19, 2000);
            Employee employee2 = new Employee("Ceyhun", 19, 1500);
            Employee employee3 = new Employee("Alli", 39, 4500);
            Employee employee4 = new Employee("Hasan", 29, 1700);

            Department department = new Department("Aygun Mall", 3);

            try
            {
                department.AddEmployee(employee1);
                department.AddEmployee(employee2);
                department.AddEmployee(employee3);
                department.AddEmployee(employee4);  
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception )
            {
                Console.WriteLine("Unknown Error");
            }

            for(int i=0; i<department.Workers.Length; i++)
            {
                Console.WriteLine("\n"+department[i]);
            }

            Console.WriteLine();
            employee1.ShowInfo();
            

            

        }
    }
}