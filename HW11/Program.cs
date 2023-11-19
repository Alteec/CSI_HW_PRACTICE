using System;
using System.Collections.Generic;

namespace HW11
{
    class Program
    {
        public enum SexEnum
        {
            Male,
            Female,
        }
        interface IEmployee
        {
            public int Id { get; set; }
            public decimal Salary { get; set; }
            public SexEnum Sex {  get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Position { get; set; }
            public string Number { get; set; }
            public DateTime Joined { get; set; }


        }

        public struct Employee : IEmployee
        {

            static private int EmployeeCounter = 0;

            static Dictionary<string, string[]> DeparmentPosition =
              new Dictionary<string, string[]>(){
                                  {"Marketing",new string[] {"Marketing Manager","Marketing Consultant","SEO Specialist"} },
                                  {"Human Resources",new string[] {"HR Manager","Recruiter","Coordinator"}},
                                  {"IT", new string[]{"Product Manager","Software Engineer","QA Engineer","Data Engineer,"}}};

            public SexEnum Sex { get; set; }
            public int Id { get; set; }
            public decimal Salary { get; set; }

            public string Name { get; set; }
            public string Surname { get; set; }
            public string Position { get; set; }
            public string Department { get; set; }

            public string Number { get; set; }
            public DateTime Joined { get; set; }
            public Employee(SexEnum Sex,string Department, decimal Salary, string Name, string Surname, string Position, string Number,DateTime Joined)
            {
                this.Department = Department;
                this.Id = EmployeeCounter;
                this.Sex = Sex;
                EmployeeCounter++;
                this.Salary = Salary;
                this.Name = Name;
                this.Surname = Surname;
                this.Position = Position;
                this.Number = Number;
                this.Joined = Joined;
            }
            public override string ToString() {
                return $"{Id}.{Name} {Surname}, {Sex}, {Position} в {Department} с {(Joined.ToString()).Split()[0]} | {Number} | ${Salary}";
            }

            public static Employee GenerateEmployee(){
                Random rand = new Random();

                DateTime from = new DateTime(2006, 1, 1, 9, 0, 0);
                DateTime to = new DateTime(2023, 11, 1, 19, 0, 0);

                TimeSpan span = to - from;
                TimeSpan randSpan = new TimeSpan(0, rand.Next(0, (int)span.TotalMinutes), 0);
                DateTime date = from + randSpan;

                Array values = Enum.GetValues(typeof(SexEnum));
                SexEnum sex = (SexEnum)values.GetValue(rand.Next(values.Length));


                string[] Name = { "Martin", "Frances", "John", "Elizabeth", "Peter", "Niles", "Samuel", "Joy", "Joann", "Shawn", "Gus" };
                string[] Surnames = { "Smith", "Johnson", "White", "Spencer", "Williams", "Jordan", "Jones", "Robinson" };
                string Num = $"+770{rand.Next(1, 9)}{rand.Next(1000000, 9999999)}";
                string department=Employee.DeparmentPosition.ElementAt(rand.Next(0, Employee.DeparmentPosition.Keys.Count)).Key;
                string position = Employee.DeparmentPosition[department][rand.Next(0, Employee.DeparmentPosition[department].Length)];
                return new Employee(Sex:sex ,Department: department,Position: position,Joined: date,Name: Name[rand.Next(0, Name.Length)], Surname: Surnames[rand.Next(0, Surnames.Length)],Number: Num, Salary: rand.Next(300000,1000000));
            }

            public static List<Employee> AllInfo(Employee[] Employees) {
                Console.WriteLine("Вывод всех работников");

                List<Employee> employees=new List<Employee>();
                foreach (Employee employee in Employees)
                {
                    Console.WriteLine(employee.ToString());
                    employees.Add(employee);

                }
                Console.WriteLine();
                return employees;
            }
            public static List<Employee> AllInfo(Employee[] Employees, SexEnum sex)
            {
                Console.WriteLine($"Фильтр по полу {sex}");

                List<Employee> employees = Employees.ToList().FindAll(employee => employee.Sex==sex).OrderBy(employee => employee.Surname).ToList();
                foreach(Employee employee in employees)
                {
                    Console.WriteLine(employee.ToString());
                }
                return employees;
            }

            public static List<Employee> SelectByPosition(Employee[] Employees, string position)
            {
                Console.WriteLine($"Фильтр по позиции {position}");

                List<Employee> list = new List<Employee>();
                foreach (Employee employee in Employees)
                {
                    if(employee.Position == position)
                    {
                        Console.WriteLine(employee.ToString());
                        list.Add(employee);
                    }
                }
                Console.WriteLine();
                return list;
            }
            public static List<Employee> ManagersSalaryMoreThanAvg(Employee[] Employees)

            {
                Console.WriteLine("Менеджеры, чья зарплата выше ср. зарплаты сотрудников:");

                decimal salary_counter = 0;
                decimal counter = 0;
                List<Employee> managers = new List<Employee>();

                foreach (Employee employee in Employees)
                {
                    if (!employee.Position.ToUpper().Contains("MANAGER")) {
                        salary_counter += employee.Salary;
                        counter ++;
                        continue;
                    }
                    managers.Add(employee);
                }
                decimal avg = salary_counter / counter;

                managers = managers.FindAll(manager=>manager.Salary>avg).OrderBy(manager=>manager.Surname).ToList();

                foreach(Employee manager in managers)
                {
                    Console.WriteLine(manager.ToString());
                }
                Console.WriteLine();

                return managers;
            }

            public static List<Employee> JoinedBefore(Employee[] Employees,DateTime date)
            {
                Console.WriteLine($"Присоединились до {date.ToString()}:");
                List<Employee> employees = Employees.ToList().FindAll(employee=>employee.Joined>date).OrderBy(employee => employee.Surname).ToList();
                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee.ToString());
                }
                Console.WriteLine();
                return employees;
            }
        }

        static void Task1()
        {
            int len;
            do
            {
                Console.Write("Length: ");
            }
            while (!int.TryParse(Console.ReadLine(), out len));

            Employee[] Employees = new Employee[len];

            for (int i = 0; i < len; i++)
            {
                Employees[i] = Employee.GenerateEmployee();
            }

            Employee.AllInfo(Employees);//Информация о всех работниках
            Employee.SelectByPosition(Employees,"Software Engineer");//Фильтр по должности
            Employee.ManagersSalaryMoreThanAvg(Employees);//Менеджеры, чья зарплата выше ср. зарплаты сотрудников
            Employee.JoinedBefore(Employees,new DateTime(2020, 1, 1));//фильтр по дате до
            Employee.AllInfo(Employees,SexEnum.Male);//Информаци о всех работнкиках определенного пола


        }
        static void Main(string[] args)
        {
            Task1();
        }
    }
}