using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIGStudents.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string CourseName { get; set; }
        public Student(string first_name, string last_name, int age, string course)
        {
            FirstName = first_name;
            LastName = last_name;
            Age = age;
            CourseName = course;
        }
        public Student()
        { }
    }
}
