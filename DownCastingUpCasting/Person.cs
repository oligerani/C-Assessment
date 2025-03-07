using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownCastingUpCasting
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Person: {Name}");
        }
    }

    // Derived class Student
    class Student : Person
    {
        public int StudentID { get; set; }

        public Student(string name, int studentID) : base(name)
        {
            StudentID = studentID;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Student: {Name}, ID: {StudentID}");
        }
    }
}

