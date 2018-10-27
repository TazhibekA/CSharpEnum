using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Student
    {

        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int AverageMark { get; set; }
        public int FamilySalary { get; set; }
        public Gender Gender { get; set; }
        public FormOfStudy FormOfStudy { get; set; }

        public Student(int id, string lastName, string name, string group, int averageMark, int familySalary, Gender gender, FormOfStudy formOfStudy)
        {
            Id = id;
            LastName = lastName;
            Name = name;
            Group = group;
            AverageMark = averageMark;
            FamilySalary = familySalary;
            this.Gender = gender;
            this.FormOfStudy = formOfStudy;
        }
    }
}
