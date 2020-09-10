using System;
using System.Collections.Generic;
using System.Text;

namespace FormatieveOpdracht1
{
    public class Dealer
    {
        private List<Card> deck;
        Deck newDeck = new Deck();

        public Dealer()
        {
            List<Card> deck = new List<Card>();

            this.deck = newDeck.getAllCards();
        }

        public List<List<Card>> kaartenUitdelen()
        {
            deck = newDeck.shuffleCards(deck);

            List<Card> playerOneDeck = new List<Card>();
            List<Card> playerTwoDeck = new List<Card>(); ;
            List<Card> playerThreeDeck = new List<Card>(); ;
            List<Card> playerFourDeck = new List<Card>(); ;

            for (int i = 0; i < 13; i++)
            {
                playerOneDeck.Add(deck[0]);
                deck.RemoveAt(0);
                playerTwoDeck.Add(deck[0]);
                deck.RemoveAt(0);
                playerThreeDeck.Add(deck[0]);
                deck.RemoveAt(0);
                playerFourDeck.Add(deck[0]);
            }

            List<List<Card>> returnList = new List<List<Card>>();

            returnList.Add(playerOneDeck);
            returnList.Add(playerTwoDeck);
            returnList.Add(playerThreeDeck);
            returnList.Add(playerFourDeck);

            return returnList;    

        }
    }
}
