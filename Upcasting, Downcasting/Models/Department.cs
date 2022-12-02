using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Upcasting__Downcasting.Exceptions;

namespace Upcasting__Downcasting.Models
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public Employee[] Workers;

        public Employee this[int index]
        {
            get => Workers[index];
            set => Workers[index] = value;
        }

        public Department(string name,int employeeLimit)
        {
            Workers=Array.Empty<Employee>();
            Name= name;
            EmployeeLimit= employeeLimit;
        }

        public void AddEmployee(Employee employee)
        {
            if(Workers.Length<EmployeeLimit )
            {
                Array.Resize(ref Workers, Workers.Length+1);
                Workers[^1] = employee;
                Console.WriteLine(Workers[^1].Name + " was Added our Depaertment");
            }
            else
            {
                throw new CapacityLimitException("Adding Error. Out of Limit");
            }
        }

    }
}
