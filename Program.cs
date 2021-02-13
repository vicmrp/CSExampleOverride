// C# How To Use The Override And Virtual Method.
// https://www.youtube.com/watch?v=HmAqUHS05c8

using System;

namespace ExampleOverrideCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Andrew", "Eberle");
            System.Console.WriteLine(student.GetFullName);

            Teacher teacher = new Teacher("Harry", "James");
            System.Console.WriteLine(teacher.GetFullName);
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
        // for at du kan overskrive en nedarvet funktion skal den have virtuel nøgleordet.
        public virtual string GetFullName
        {
            get
            {
                return "Studen's Name: " + this.FirstName + " " + this.LastName;
            }
        }
    }
    class Teacher : Student
    {
        public Teacher(string fn, string ln) : base (fn, ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }
        public override string GetFullName
        {
            get
            {
                return "Teacher's Name: " + this.FirstName + " " + this.LastName;
            }
        }
    }
}