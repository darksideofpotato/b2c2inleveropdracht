using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace FormatieveOpdracht1
{
    public class Game
    {
        private Dealer dealer;
        private List<Player> players;

        public Game()
        {
            this.dealer = new Dealer();
            this.players = new List<Player>();
        }
        public void setPlayers()
        {

            Console.WriteLine("Wie is de eerste speler?");
            string playerOne = Console.ReadLine();
            Player one = new Player(playerOne);
            players.Add(one);
            one.setNaam(playerOne);

            Console.WriteLine("Wie is de tweede speler?");
            string playerTwo = Console.ReadLine();
            Player two = new Player(playerTwo);
            players.Add(two);
            two.setNaam(playerTwo);

            Console.WriteLine("Wie is de derde speler?");
            string playerThree = Console.ReadLine();
            Player three = new Player(playerThree);
            players.Add(three);
            three.setNaam(playerThree);

            Console.WriteLine("Wie is de vierde speler?");
            string playerFour = Console.ReadLine();
            Player four = new Player(playerFour);
            players.Add(four);
            four.setNaam(playerFour);

        }

        public void StartGame()
        {
            setPlayers();

            Console.WriteLine("Dealer: Druk op enter om de kaarten te shufflen en uit te delen");
            Console.ReadLine();
            List<List<Card>> shuffledDecks = this.dealer.kaartenUitdelen();

            foreach (Player player in players)
            {
                player.setHand(shuffledDecks[0]);

                shuffledDecks.RemoveAt(0);

                Console.WriteLine(player.getName() + " met de kaarten ");
                player.getHand();
                Console.WriteLine("   ");
            }

            bool flag = true;

            while (flag == true)
            {
                Console.WriteLine("Druk op 1 om de hand van speler 1 te zien, 2 voor speler 2 enzovoorts. " +
                    "Kies een andere key om het programma af te sluiten");
             
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        players[0].getHand();
                        break;
                    case "2":
                        players[1].getHand();
                        break;
                    case "3":
                        players[2].getHand();
                        break;
                    case "4":
                        players[3].getHand();
                        break;
                    default:
                        flag = false;
                        break;
                } 
            }
            
            

        }
    }
}
