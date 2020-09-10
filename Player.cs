using System;
using System.Collections.Generic;
using System.Text;

namespace FormatieveOpdracht1
{
    public class Player
    {
        private string name;
        private List<Card> hand;

        public Player(string inputName)
        {
            this.name = inputName;
        }

        public string getName()
        {
            return name;
        }
        public void setHand(List<Card> kaarten)
        {
            this.hand = kaarten;
        }
        public void getHand()
        {
            foreach(Card card in hand)
            {
                Console.WriteLine(card.getRank().ToString() + " of " + card.getSuit());
            }
        }
        public void setNaam(string inputName)
        {
            this.name = inputName;
        }
        public void raapKaart()
        {
            //
        }

    }
}
