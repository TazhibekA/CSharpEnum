using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Company
    {
        public int Id { get; set; }
        public List<Employee> EmployeeList { get; set; }

        public Company(int id, List<Employee> employeeList)
        {
            Id = id;
            EmployeeList = employeeList;
        }

        public Company()
        {
            this.EmployeeList = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            EmployeeList.Add(employee);

        }

        public void ShowAllEmployees()
        {
            for (int i = 0; i < this.EmployeeList.Count; i++)
            {
                Console.WriteLine(this.EmployeeList[i].Id + " " + this.EmployeeList[i].LastName + " " + this.EmployeeList[i].Name + " " + this.EmployeeList[i].Position+ " "+ this.EmployeeList[i].Salary);
            }
        }
    }
}
