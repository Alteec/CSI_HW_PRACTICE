using System;
using Teacher;
using StudentWithAdvisor;
using Student;

namespace HW10
{
    public class HW10
    {


        static void Main()
        {
            Person.Person person1 = new Person.Person("David", "Cera", 33);
            Teacher.Teacher teacher1 = new Teacher.Teacher("Michael", "Cera", 40, new Subject("Math","Math"), 3600000);
            Teacher.Teacher teacher2 = new Teacher.Teacher("David", "Cera", 45, new Subject("Physics", "Physics"), 3600000);
            Student.Student student1 = new Student.Student("George", "Michael", 20, 2);
            StudentWithAdvisor.StudentWithAdvisor student2 = new StudentWithAdvisor.StudentWithAdvisor("Michael", "George", 21, teacher1,2);
            student2.subjects.Add(new Subject("Math", "Math"));

            Object[] arr = new Object[] {person1,teacher1,teacher2,student1,student2 };

            int student_counter = 0;
            int person_counter = 0;
            int teacher_counter = 0;

            foreach (Object obj in arr)
            {
                Console.WriteLine(obj.ToString());
                Console.WriteLine(obj.Equals(arr[2]));
                Console.WriteLine(obj.GetHashCode());
                Console.WriteLine("------");

                if(obj is Student.Student || obj is StudentWithAdvisor.StudentWithAdvisor)
                {
                    Student.Student? student = obj as Student.Student;
                    student.course += 1;
                    student_counter++;
                }
                else if(obj is Teacher.Teacher) {
                    teacher_counter++;
                }
                else if(obj is Person.Person)
                {
                    person_counter++;
                }
            }

            Console.WriteLine($"Teachers:{teacher_counter}\nStudents:{student_counter}\nPersons:{person_counter}");

            Console.WriteLine(Teacher.Teacher.RandomTeacher(arr));





        }
    }
}