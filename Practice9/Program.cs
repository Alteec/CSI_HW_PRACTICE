using System.Collections.Concurrent;

namespace Program
{
    class Practice9
    {

        abstract class Storage
        {
            protected string Name { get; set; }
            protected string Model {  get; set; }
            public Storage(string name, string model)
            {
                this.Name = name;
                this.Model = model;
            }

            public abstract double GetVolume();
            public abstract void Copy();
            public abstract double FreeSpace();
            public abstract string GetInfo();

            public static void PrintAll(Storage[] arr)
            {
                foreach (Storage s in arr)
                {
                    Console.WriteLine(s.GetInfo());
                }
            }

            public static double GetAllVolume(Storage[] arr)
            {
                double counter = 0;
                foreach (Storage s in arr)
                {
                    counter += s.GetVolume();
                }
                return counter;
            }
        }

        class Flash : Storage
        {
            public double Speed {  get; set; }
            public double Volume {  get; set; }

            public int UsedSpace {  get; set; }

            public Flash(string name, string model,double speed,double volume) : base(name, model)
            {
                Speed = speed;
                Volume = volume;
                UsedSpace = 0;
            }
            public override void Copy()
            {
                throw new NotImplementedException();
            }

            public override double FreeSpace()
            {
                return Volume-UsedSpace;
            }

            public override string GetInfo()
            {
                string info = $"Name {Name}\nModel:{Model}\nSpace: {UsedSpace}/{Volume}\n";
                return info;
            }

            public override double GetVolume()
            {
                return Volume;
            }
        }

        class DVD : Storage
        {

            public double ReadSpeed { get; set; }
            public double WriteSpeed { get; set; }

            public Types Type { get; set; }

            private double _Storage;

            public double UsedSpace { get; set; }

            public DVD(string name, string model, double read, double write,Types type) : base(name, model)
            {
                ReadSpeed = read;
                WriteSpeed = write;
                Type = type;
                if (type == Types.OneLayer)
                {
                    _Storage = 4.7;
                }
                else
                {
                    _Storage = 9;
                }
            }


            public override void Copy()
            {
                throw new NotImplementedException();
            }

            public override double FreeSpace()
            {
                return _Storage;
            }

            public override string GetInfo()
            {
                string info = $"Name {Name}\nModel:{Model}\nSpace:{_Storage}\n";
                return info;
            }

            public override double GetVolume()
            {
                return _Storage;
            }


        }

        class HDD : Storage
        {

            public double Speed { get; set; }
            public List<double> PartitionsVolume {  get; set; }
            public List<double> PartitionsUsed { get; set; }


            public int Partitions {  get; set; }

            public HDD(string name,string model,double speed, List<double> partitions):base(name,model)
            {
                Speed = speed;
                PartitionsVolume = partitions;
                Partitions=PartitionsVolume.Count;
                PartitionsUsed= new List<double>();
                foreach(double part in PartitionsVolume)
                {
                    PartitionsUsed.Add(0);
                }

            }

            public override void Copy()
            {
                throw new NotImplementedException();
            }

            public override double FreeSpace()
            {
                double free = 0;
                for(int i=0;i<PartitionsVolume.Count;i++)
                {
                    free+=(PartitionsVolume[i] - PartitionsUsed[i]);
                }
                return free;
            }

            public override string GetInfo()
            {
                string info = $"Name {Name}\nModel:{Model}\nSpace:{Partitions} partitions of {this.GetVolume()} total\n";
                return info;
            }

            public override double GetVolume()
            {
                double volume = PartitionsVolume.Sum();
                return volume;
            }
        }

        enum Types
        {
            OneLayer,
            TwoLayer,
        }
        static void Main(string[] args)
        {
            HDD hdd = new HDD("Seagate HDD", "BarraCuda", 6, new List<double> { 512, 512 });
            Flash flash = new Flash("SAMSUNG", "Fit Plus", 0.400, 128);
            DVD dvd = new DVD("Apple USB", "Superdrive", 0.011, 0.011,Types.OneLayer);

            Storage[] arr = {hdd,flash,dvd};

            Storage.PrintAll(arr);
            Console.WriteLine("Total: "+Storage.GetAllVolume(arr));
            //todo

        }
    }
}