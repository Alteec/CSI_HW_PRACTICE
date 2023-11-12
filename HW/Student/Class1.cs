using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person;

namespace Student
{

    public class Student : Person.Person
    {
        public int course { get; set; }
        public List<Subject> subjects;

        public Student(string name, string surname, int age) : base(name, surname, age) { }

        public Student(string name, string surname, int age, int course) : base(name, surname, age)
        {
            this.course = course;
            this.subjects = new List<Subject>();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Student {this.name} {this.surname},{this.age}");
        }

        static public Student RandomTeacher(Object[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Student)
                {
                    counter++;
                }
            }
            Student[] teachers = new Student[counter];
            counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Student)
                {
                    teachers[counter] = (Student)arr[i];
                    counter++;
                }
            }
            Random random = new Random();
            int randel = random.Next(0, teachers.Length);

            return teachers[randel];
        }

        public override string ToString()
        {
            string a = $"{this.name} {this.surname}";
            return a;
        }
    }
}
