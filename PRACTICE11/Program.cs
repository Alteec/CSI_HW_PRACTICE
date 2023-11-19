using System;
using System.ComponentModel.DataAnnotations;

namespace Practice11
{
    class Program
    {
        public enum Vacancies{
            [Display(Name = "Software Engineer")]
            SoftwareEngineer,
            [Display(Name = "Product Manager")]
            ProductManager,
            [Display(Name = "QA Engineer")]
            GoodBoy,
            [Display(Name = "Accountant")]
            BadBoy
        }

        struct Employee
        {
            public string Name { get; set;}
            public Vacancies Vacancy { get; set;}
            DateTime Joined { get; set;}
            int Salary { get; set; }

        }
        static void Main(string[] args)
        {

        }
    }
}