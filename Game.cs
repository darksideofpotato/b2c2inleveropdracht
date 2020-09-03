using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FormatieveOpdracht1
{
    public class Game
    {
        private object dealer;
        private List<Player> players;
        private List<string> playerNames;

        public void setPlayers()
        {
            players = new List<Player>();
            playerNames = new List<string>();

            Console.WriteLine("Wie is de eerste speler?");
            string playerOne = Console.ReadLine();
            Player one = new Player(playerOne);
            players.Add(one);
            playerNames.Add(playerOne);

            Console.WriteLine("Wie is de tweede speler?");
            string playerTwo = Console.ReadLine();
            Player two = new Player(playerTwo);
            players.Add(two);
            playerNames.Add(playerTwo);

            Console.WriteLine("Wie is de derde speler?");
            string playerThree = Console.ReadLine();
            Player three = new Player(playerThree);
            players.Add(three);
            playerNames.Add(playerThree);

            Console.WriteLine("Wie is de vierde speler?");
            string playerFour = Console.ReadLine();
            Player four = new Player(playerFour);
            players.Add(four);
            playerNames.Add(playerFour);

        }

        public void getPlayerNames()
        {
            foreach (string name in playerNames)
            {
                Console.WriteLine(name);
            }
        }

        public void StartGame()
        {
            setPlayers();
            getPlayerNames();

            Deck newDeck = new Deck();
            newDeck.getAllCards();

            

            
            //dealer.deelkaartenuittotdeckleegis
        }
    }
}
