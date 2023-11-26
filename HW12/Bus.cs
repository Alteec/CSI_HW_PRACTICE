using HW12;
using System.Reflection;

class Bus : Car
{

    public Bus(string Model, int maxspeed, int zerotohundred) : base(Model, maxspeed, zerotohundred)
    {
    }
    public override string Info()
    {
        return $"{Model} Bus";
    }

}