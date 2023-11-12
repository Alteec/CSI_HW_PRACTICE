using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{this.name} {this.surname},{this.age}");
        }

        public override string ToString()
        {
            string a = $"{this.name} {this.surname},{this.age}";
            return a;
        }

        static public Person RandomTeacher(Object[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Person)
                {
                    counter++;
                }
            }
            Person[] teachers = new Person[counter];
            counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Person)
                {
                    teachers[counter] = (Person)arr[i];
                    counter++;
                }
            }
            Random random = new Random();
            int randel = random.Next(0, teachers.Length);

            return teachers[randel];
        }
    }
}
