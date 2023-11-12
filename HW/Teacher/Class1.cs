using Student;
using System.Reflection.Metadata.Ecma335;

namespace Teacher
{
    public class Teacher : Student.Student
    {
        public Subject subject;
        public decimal salary { get; set; }
        public List<Student.Student> students { get; set; }

        public Teacher(string name, string surname, int age, Subject subject, decimal salary) : base(name, surname, age)
        {

            this.subject = subject;
            this.salary = salary;
            this.students = new List<Student.Student>();
        }

        public virtual void Print()
        {
            Console.WriteLine($"{this.subject.name} teacher {this.name} {this.surname},{this.age}\n Salary: {this.salary}");
        }

        static public Teacher RandomTeacher(Object[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Teacher)
                {
                    counter++;
                }
            }
            Teacher[] teachers=new Teacher[counter];
            counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Teacher)
                {
                    teachers[counter] = (Teacher)arr[i];
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
        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            return true;
        }
    }
}
