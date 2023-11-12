using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Subject
    {
            public string name { get; set; }
            public string description { get; set; }
            public Subject(string name, string description) {
            this.name=name;
            this.description = description;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{name} {description}");
        }

        public override string ToString()
        {
            string a = $"{this.name}";
            return a;
        }


    }
}
