using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT2017G1Week1
{
    class Program
    {
        class Student
        {
            public string name;
            public string surname;
            public int age;
            public double gpa;

            public Student(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }

            public double GetGPA()
            {
                return gpa;
            }
        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">arguments</param>
        static void Main(string[] args)
        {
            // Student 1
            /*
             * comments
             * 
             */ 
            Student a = new Student("Marat", "Abuov", 20);
            a.gpa = 4.0;

            // Student 2
            Student b = new Student("aaa", "bbb", 21);
            b.age = 21;
            b.gpa = 3.0;

            Console.WriteLine(a.name);
            Console.WriteLine(b.name);
            Console.ReadKey();

        }
    }
}
