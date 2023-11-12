using System;

namespace House
{

    public class House
    {


        public List<object> Remains;
        public List<object> Built;


        public int walls_req {  get; set; }
        public int windows_req { get; set; }
        public int basements_req { get; set; }

        public int roofs_req { get; set; }
        public int doors_req { get; set; }

        public House(int walls_req, int windows_req, int basements_req, int roofs_req, int doors_req)
        {
            this.walls_req = walls_req;
            this.windows_req = windows_req;
            this.basements_req = basements_req;
            this.roofs_req = roofs_req;
            this.doors_req = doors_req;
            this.Remains= new List<object>();
            this.Built = new List<object>();


            for (int i=0; i<walls_req;i++) { 
                Remains.Add(new Walls());
            }
            for (int i = 0; i < windows_req; i++)
            {
                Remains.Add(new Window());
            }
            for (int i = 0; i < basements_req; i++)
            {
                Remains.Add(new Basement());
            }
            for (int i = 0; i < roofs_req; i++)
            {
                Remains.Add(new Roof());
            }
            for (int i = 0; i < doors_req; i++)
            {
                Remains.Add(new Door());
            }
        }

        public override string ToString()
        {
            string remains = string.Join("\n", Remains);
            string built = string.Join("\n", Built);


            DateTime date = DateTime.Now;
            string a = $"{date}\nBuilt:\n{built}\n___\nRemains: \n{remains}";
            return a;
        }

    }

    public class Walls : IPart
    {
    }

    public class Door:IPart
    {

    }

    public class Window:IPart
    {
    }

    public class Roof : IPart
    {

    }

    public class Basement:IPart
    {

    }

    public class Team
    {
        public List<Worker> workers { get; set; }
        TeamLeader leader {  get; set; }
        public Team(TeamLeader leader)
        {
            this.workers = new List<Worker>();
            this.leader = leader;
        }

        public void Build(House house)
        {
            while (house.Remains.Any())
            {
                foreach (Worker worker in workers)
                {
                    worker.Build(house);
                }
                leader.formReport(house);
            }
            Console.WriteLine("  __\n /  \\\n/____\\\n|__  |\n|_|__|");
        }
    }

    public class Worker: IWorker
    {
        public string name { get; set; }
        public Worker(string name)
        {
            this.name = name;
        }

        public void Build(House house)
        {
            foreach (Object obj in house.Remains)
            {
                if (obj is Basement)
                {
                    house.Built.Add(obj as Basement);
                    house.Remains.Remove(obj as Basement);
                    return;
                }
            }
            Random random = new Random();
            int rand=random.Next(house.Remains.Count);
            house.Built.Add(house.Remains[rand]);
            house.Remains.Remove(house.Remains[rand]);
        }
    }

    public class TeamLeader: IWorker
    {
        public string name { get; set; }
        public TeamLeader(string name)
        {
            this.name = name;
        }
        public void formReport(House house)
        {
            string houseInfo = house.ToString();
            Console.WriteLine($"_____\nReport:\n{houseInfo}\nLeader:{this.name}\n_____");
        }
    }

    interface IWorker
    {
        string name { get; set; }
    }

    public interface IPart
    {

    }
    public class Practice10
    {


        static void Main()
        {
            House house = new House(4, 4, 1, 1, 2);

            TeamLeader leader = new TeamLeader("Eddie");

            Team team = new Team(leader);
            team.workers.Add(new Worker("Frasier"));
            team.workers.Add(new Worker("Niles"));
            team.workers.Add(new Worker("Martin"));

            team.Build(house);

        }
    }
}