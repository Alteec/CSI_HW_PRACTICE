using HW12;
using System.Reflection;

class Truck : Car
{

    public Truck(string Model, int maxspeed, int zerotohundred) : base(Model, maxspeed, zerotohundred)
    {
    }
    public override string Info()
    {
        return $"{Model} Truck";
    }

}