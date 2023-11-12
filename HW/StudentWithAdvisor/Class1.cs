using Student;
using Teacher;

namespace StudentWithAdvisor
{
    public class StudentWithAdvisor:Student.Student
    {
        public Teacher.Teacher teacher { get; set; }

        public StudentWithAdvisor(string name, string surname, int age,Teacher.Teacher teacher,int course) : base(name, surname, age,course) { 
            this.teacher = teacher;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Student {this.name} {this.surname},{this.age}\nAdvisor: {this.teacher}");
        }

        public override string ToString()
        {
            string a = $"{this.name} {this.surname}\nAdvisor: {this.teacher}";
            return a;
        }
    }
}