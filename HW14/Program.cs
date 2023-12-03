using System;

namespace HW14
{

    class HW14
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("John");
            Player player2 = new Player("Martin");
            Player player3 = new Player("Lee");
            Player player4 = new Player("Paul");


            Game game =new Game(new List<Player> { player1, player2,player3,player4 });
            
            game.Shuffle();
            game.Give();
            game.Start();


        }
    }
}