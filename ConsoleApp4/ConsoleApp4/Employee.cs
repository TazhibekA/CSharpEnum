using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee
    {
        

        public Employee()
        {
        }

        public Employee(int id, string lastName, string name, Positions position, int salary)
        {
            Id = id;
            LastName = lastName;
            Name = name;
            Position = position;
            Salary = salary;
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public Positions Position { get; set; }

        public int Salary { get; set; }
    }
}
