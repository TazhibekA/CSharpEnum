using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondTask();
            Console.ReadLine();

        }
            static void FirstTask() {
                string sizeListOfEmployee;
                Console.WriteLine("Choose count of employees: ");
                sizeListOfEmployee = Console.ReadLine();
                int sizeListOfEmployeeInt = int.Parse(sizeListOfEmployee);
                Company company = new Company();
                Console.WriteLine("Choose average salary of employees: ");
                string averageSalary = Console.ReadLine();
                int averageSalaryInt = int.Parse(averageSalary);

            for (int i = 1; i <= sizeListOfEmployeeInt; i++)
                {
                    Console.WriteLine($"Enter lastname of {i} employee: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine($"Enter name of {i} employee: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Choose the position: 1 - boss   2 - manajer   3 - worker");
                    string position = Console.ReadLine();

                    Positions positionChoose;
                    if (int.Parse(position) == 1)
                    {
                        positionChoose = Positions.boss;
                    }
                    else if (int.Parse(position) == 2)
                    {
                        positionChoose = Positions.manajer;
                    }
                    else if (int.Parse(position) == 3)
                    {
                        positionChoose = Positions.worker;
                    }
                    else
                    {
                        positionChoose = Positions.none;

                    }
                    Console.WriteLine($"Enter salary of {i} employee: ");
                    string salary = Console.ReadLine();
                    int salaryInt = int.Parse(salary);
                    Employee employee = new Employee(i, lastName, name, positionChoose, salaryInt);
                    company.AddEmployee(employee);
                }

            
            company.ShowAllEmployees();
                Console.ReadLine();


            }

        static void SecondTask() {
            int minSalary = 200000;
            Student firstStudent = new Student(1,"Tazhibek","Aknur","SEP-2",12,250000,Gender.female,FormOfStudy.free);
            Student secondStudent = new Student(2,"Mazhitov","Nurik","SEP-2",5,550000,Gender.male,FormOfStudy.free);
            Student thirdStudent = new Student(3,"Orazbekova","Balym","SEP-2",9,350000,Gender.female,FormOfStudy.paid);
            Student fourthStudent = new Student(4,"Asmiyeva","Inkara","SEP-2",10,250000,Gender.female,FormOfStudy.free);
            Student fifthStudent = new Student(5,"Tarasov","Asylbek","SEP-2",11,150000,Gender.female,FormOfStudy.paid);

            Dormintory dormintory = new Dormintory();
            dormintory.AddStudent(firstStudent);
            dormintory.AddStudent(secondStudent);
            dormintory.AddStudent(thirdStudent);
            dormintory.AddStudent(fourthStudent);
            dormintory.AddStudent(fifthStudent);

            dormintory.ShowAllStudents();
            Console.WriteLine();
            Console.WriteLine("List of students who will live in dormintary: ");
            dormintory.ListStudentsInDormintary(minSalary);
            Console.ReadLine();
        }


     }
}


