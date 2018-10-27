using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Dormintory
    {
        public int Id { get; set; }
        public List<Student> StudentList { get; set; }

        public Dormintory()
        {
            this.StudentList = new List<Student>();
        }
        public void ListStudentsInDormintary(int minSalary)
        {
            for (int i = 0; i < this.StudentList.Count; i++)
            {
                if(this.StudentList[i].FamilySalary < minSalary)
                Console.WriteLine(this.StudentList[i].Id + " " + this.StudentList[i].LastName + " " + this.StudentList[i].Name + " " + this.StudentList[i].AverageMark + " " + this.StudentList[i].FamilySalary+ " " + this.StudentList[i].Gender+" "+ this.StudentList[i].FormOfStudy);
            }
        }

        public void AddStudent(Student student)
        {
            StudentList.Add(student);

        }
        public void ShowAllStudents()
        {
            for (int i = 0; i < this.StudentList.Count; i++)
            {
                Console.WriteLine(this.StudentList[i].Id + " " + this.StudentList[i].LastName + " " + this.StudentList[i].Name + " " + this.StudentList[i].AverageMark + " " + this.StudentList[i].FamilySalary + " " + this.StudentList[i].Gender + " " + this.StudentList[i].FormOfStudy);
            }
        }

    }
}
