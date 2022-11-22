using System;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace Assignment10
{
    abstract public class Person
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string HomeTown { get; set; }

        abstract public string Display();
        static void Main(String[] args)
        {
            int numStudents;
            int numTeachers;
            WriteLine("Welcome to my program!");
            Write("Enter the number of students you wish to enter >> ");
            Int32.TryParse(ReadLine(), out numStudents);
            List<Student> StudentList = new List<Student>();
            for (int i = 0; i < numStudents; i++)
            {
                Student student = new Student();
                student.PersonId = i+1;
                Write("Enter the name of student {0} >> ", student.PersonId);
                student.FullName = ReadLine();
                Write("Where does student {0} live? >> ", student.PersonId);
                student.HomeTown = ReadLine();
                Write("What is student {0} majoring in? >> ", student.PersonId);
                student.Major = ReadLine();
                Write("Enter the name of student {0}'s advisor >> ", student.PersonId);
                student.Advisor = ReadLine();
                StudentList.Add(student);
            }
            Write("Enter the number of teachers you wish to enter >> ");
            Int32.TryParse(ReadLine(), out numTeachers);
            List<Teacher> TeacherList = new List<Teacher>();
            for (int i = 0; i < numTeachers; i++)
            {
                Teacher teacher = new Teacher();
                teacher.PersonId = i+1;
                Write("Enter the name of teacher {0} >> ", teacher.PersonId);
                teacher.FullName = ReadLine();
                Write("Where does teacher {0} live? >> ", teacher.PersonId);
                teacher.HomeTown = ReadLine();
                Write("How much does teacher {0} make a year? >> ", teacher.PersonId);
                double temp;
                Double.TryParse(ReadLine(), out temp);
                teacher.Salary = temp;
                Write("How many years has teacher {0} been working in {1}? >> ", teacher.PersonId, teacher.HomeTown);
                int temp2;
                Int32.TryParse(ReadLine(), out temp2);
                teacher.YearsOfService = temp2;
                TeacherList.Add(teacher);
            }
            WriteLine("========================");
            WriteLine("All students: ");
            WriteLine("-------------------------");
            foreach(Student student in StudentList)
            {
                WriteLine("Student " + student.PersonId.ToString() + " | " + student.Display());
            }
            WriteLine("=========================");
            WriteLine("All teachers: ");
            WriteLine("-------------------------");
            foreach(Teacher teacher in TeacherList)
            {
                WriteLine("Teacher " + teacher.PersonId + 1.ToString() + " | " + teacher.Display());
            }
        }
    }
    public class Student : Person
    {
        public string Major { get; set; }
        public string Advisor { get; set; }

        public override string Display()
        {
            return "Name: " + FullName + ", Hometown: " + HomeTown + ", Major: " + Major + ", Advisor: " + Advisor;
        }
    }
    public class Teacher : Person
    {
        public double Salary { get; set; }
        public int YearsOfService { get; set; }

        public override string Display()
        {
            return "Name: " + FullName + ", Hometown: " + HomeTown + ", Salary: " + Salary.ToString("C2") + ", Years of Service: " + YearsOfService;
        }
    }
}