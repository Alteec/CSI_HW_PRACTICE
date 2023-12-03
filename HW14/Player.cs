using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Player(string Name)
        {

            this.Name = Name;
        }

        public void ShowCards()
        {
            Console.Write($"{Name}: ");

            foreach (var card in Cards)
            {
                Console.Write($"{card},");
            }
            Console.WriteLine("\n");

        }

        public override string ToString()
        {
            return $"{Name}";
        }


    }
}
