using System;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace StudentObject
{
    class CreateStudents3
    {
        static void Main()
        {
            Student[] students = new Student[8];
            int x;
            int id;
            string name;
            double gpa;
            for(x = 0; x < students.Length; x++)
            {
                GetData(out id, out name, out gpa);
                students[x] = new Student(id, name, gpa);
            }
            Array.Sort(students);
            WriteLine("Sorted List:");
            for(x = 0; x < students.Length; x++)
            {
                Display(students[x]);
            }
        }
        static void Display(Student stu)
        {
            WriteLine("{0, 5} {1, -10}{2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }
        static void GetData(out int id, out string name, out double gpa)
        {
            string inString;
            Write("Please enter student ID number >> ");
            inString = ReadLine();
            int.TryParse(inString, out id);
            Write("Please enter last name for student {0} >> ", id);
            name = ReadLine();
            Write("Please enter grade point average >> ");
            inString = ReadLine();
            double.TryParse(inString, out gpa);
        }
    }
    class Student : IComparable
    {
        private int idNumber;
        private string lastName;
        private double gradePointAverage;
        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;
        public int IdNumber { get; set; }
        public string LastName { get; set; }
        public double GradePointAverage
        {
            get { return gradePointAverage; }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }
        public Student(int id, string name, double gpa)
        {
            IdNumber = id;
            LastName = name;
            GradePointAverage = gpa;
        }
        public Student() : this(0, "XXX", 0.0)
        {
        }
        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            Student temp = (Student)o;
            if (this.IdNumber > temp.IdNumber)
                returnVal = 1;
            else
                if (this.IdNumber < temp.IdNumber)
                    returnVal = -1;
                else
                    returnVal = 0;
            return returnVal;
        }
    }
}
