using System.Xml.Linq;

namespace Program
{
    class HW9
    {
        abstract class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Salary { get; set; }

            public Employee(string name, int age,decimal salary)
            {
                Name = name;
                Age = age;
                Salary = salary;
            }

            virtual public string GetInfo()
            {
                string info = $"Name: {Name}\nAge:{Age}\nSalary:{Salary}";
                Console.WriteLine(info);
                return info;
            }
            virtual public decimal CalculateAnnualSalary()
            {
                return Salary*12;
            }
        }

        class Manager:Employee
        {
            public double Bonus { get; set; } = 11.75;

            public Manager(string name, int age, decimal salary) :base(name,age,salary)
            {
            }

            public Manager(string name, int age, decimal salary,double bonus) : this(name, age, salary)
            {
                Bonus= bonus;
            }

            public override decimal CalculateAnnualSalary()
            {
                decimal baseSalary = base.CalculateAnnualSalary();
                return baseSalary+((baseSalary*(decimal)Bonus)/100);
            }
        }

        class Developer : Employee
        {
            int LinesOfCodesPerDay { get; set; } = 0;
            double BonusPerThousand { get; set; } = 0.5;

            public Developer(string name, int age, decimal salary):base(name, age, salary)
            {

            }

            public Developer(string name, int age, decimal salary,int lines) : this(name, age, salary)
            {
                LinesOfCodesPerDay = lines;
            }
            public Developer(string name, int age, decimal salary, int lines, double bonus) : this(name, age, salary,lines)
            {
                BonusPerThousand = bonus;
            }

            public override decimal CalculateAnnualSalary()
            {
                decimal baseSalary = base.CalculateAnnualSalary();
                return baseSalary + (baseSalary*((LinesOfCodesPerDay/1000)*(decimal)BonusPerThousand)/100);
            }
        }





        static void Main(string[] args)
        {
            Manager manager = new Manager("Martin", 22, 100000);
            Developer developer = new Developer("Mark", 21, 2342322);
            Console.WriteLine($"{manager.GetInfo()}\nAnnual Salary: {manager.CalculateAnnualSalary()}");
            Console.WriteLine($"\n\n\n{developer.GetInfo()}\nAnnual Salary: {developer.CalculateAnnualSalary()}");

        }
    }
}