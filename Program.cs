// C# How To Use The Override And Virtual Method.
// https://www.youtube.com/watch?v=HmAqUHS05c8

using System;

namespace CSExampleOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Andrew", "Eberle");
            System.Console.WriteLine(student.GetFullName);
        }
    }
    class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(string fn, string ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }
        public string GetFullName
        {
            get
            {
                return "Studen's Name: " + this.FirstName + " " + this.LastName;
            }
        }
        class Teacher : Student
        {
            public Teacher(string fn, string ln) 
            {
                this.FirstName = fn;
                this.LastName = ln;
            }
        }
    }

}