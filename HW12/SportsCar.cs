using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class SportsCar : Car
    {

        public SportsCar(string Model, int maxspeed, int zerotohundred) : base(Model, maxspeed, zerotohundred)
        {
        }
        public override string Info()
        {
            return $"{Model} SportsCar";
        }

    }
}
