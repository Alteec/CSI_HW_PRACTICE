using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace HW12
{
    class HW12
    {
        class Race
        {
            public delegate void RaceEvent(Car car);
            RaceEvent Drive = (Car car) => car.Drive();
            RaceEvent Finish = (Car car) => car.Finish();

            List<Car> Cars { get; set; }
            List<Car> Top = new List<Car>();

            int DistanceM { get; set; }

            public Race(List<Car> Cars, int DistanceKM)
            {
                this.Cars = Cars;
                this.DistanceM = DistanceKM * 1000;
            }

            public void PrintWinners()
            {
                for (int i = 0; i < Top.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{Top[i].Info()}");
                }
            }
            public void CarAction(RaceEvent ev,Car car)
            {
                ev.Invoke(car);
            }
            public void StartRace()
            {
                while (Top.Count != Cars.Count)
                {
                    Console.Clear();

                    foreach(var car in Cars)
                    {
                        if (car.Travelled <= DistanceM)
                        {
                            CarAction(Drive,car);
                            continue;
                        }
                        if (!Top.Contains(car))
                        {
                            Top.Add(car);
                        }
                        
                    }

                    PrintWinners();
                    Thread.Sleep(1000);

                }
            }

        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new SportsCar("A",180, 8));
            cars.Add(new Truck("B",110, 9));
            cars.Add(new Bus("C", 80, 20));
            cars.Add(new SportsCar("D", 160, 8));
            Race race1 = new Race(cars, 10);
            race1.StartRace();
        }
}
}