using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructors
{
    public class Student
    {
        public int RollNumber;
        public string FirstName;
        public string LastName;
        public static string CourseName = "Dot Net";


        public Student()//constructor (default constuctor or parameterless constuctor)
        {
            Console.WriteLine($"public student() constructor called");
            RollNumber = 1;
            FirstName = "Farin";
            LastName = "Jakate";
            //// CourseName = "Dot Net";
        }
        //parameterized Constructor
        public Student(int rn, string fn, string ln)
        {
            Console.WriteLine($"student(int rn,string fn, string ln) constructor called");
            
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
        }

        public void Details()
        {
            Console.WriteLine($"Roll number:{RollNumber} FullName:{FirstName} {LastName} CourseName:{CourseName}");

        }
        static Student()//here created static constructor because courseName is static
        {
            Console.WriteLine($"static student() constructor called");
            CourseName = "DotNet";// this value will be access because constructor runs after the class and we take value in a class fields  also
        }

        public void Initialize(int rn, string fn, string ln)
        {
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
        }

        //we are writing one more type of constructor here
        //copy constructor
        public Student(Student s)
        {
            this.RollNumber = s.RollNumber;
            this.FirstName = s.FirstName;
            this.LastName = s.LastName;

        }
    }
}
  

