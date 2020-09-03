using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FormatieveOpdracht1
{
    public class Deck
    {
        private int deckGrootte;
        private List<Card> cards;
        private List<string> shuffledCards = null;


        public void getAllCards()
        {
            // Functie die alle kaarten in het spel brengt. Maakt een range van
            // 1 tot 13 (aantal ranks), en maakt voor elke suit 13 hiervan aan
            // en stopt ze vervolgens in de 'cards' list. 
            cards = new List<Card>();

            IEnumerable<int> ranks = Enumerable.Range(1, 13);

            foreach(int rank in ranks)
            {
                cards.Add(new Card("clubs", rank));
                cards.Add(new Card("hearts", rank));
                cards.Add(new Card("spades", rank));
                cards.Add(new Card("diamonds", rank));
            }

            ////////////////// Tests om te zien of de kaarten werken
            foreach(var card in cards)
            {
                Console.WriteLine(card.getRank().ToString() + " " + card.getSuit());
            }
            Console.WriteLine(cards.Count());
        }

        public Deck()
        {
            this.deckGrootte = 52;
            this.cards = cards;
        }
        public void shuffleCards(List<string> unshuffledCards)
        {
            //hier komt de method
        }

    }
}
