using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    abstract class Car
    {

        public int Speed { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        private int MaxSpeedMPS { get; set; }
        public int ZeroToHundred { get; set; }
        private int Accelaration;
        public int Travelled = 0;
        public Car(string Model, int maxspeed, int zerotohundred)
        {
            this.Model = Model;
            this.MaxSpeed = maxspeed;
            this.ZeroToHundred = zerotohundred;
            this.Accelaration = (100 / zerotohundred) * 1000 / 60;
            this.Speed = 0;
            this.MaxSpeedMPS = maxspeed * 1000 / 60;
        }
        public virtual void Drive()
        {
            if (Speed + Accelaration < MaxSpeedMPS)
            {
                Speed += Accelaration;
                Accelaration += Speed / Accelaration;
            }
            else
            {
                Speed = MaxSpeedMPS;
            }
            Travelled += Speed;
            string test = new String('_', Travelled / 1000);
            Console.WriteLine($"{test}{this.Info()}");
        }

        public abstract string Info();
        public virtual void Finish()
        {
            string test = new String('_', Travelled / 1000);
            Console.WriteLine($"{test}{this.Info()}");
        }

    }
}
